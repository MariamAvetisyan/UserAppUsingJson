using FluentValidation;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace DashboardUI.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator(bool includerId, bool checkOthers)
        {
            if (includerId)
            {
                RuleFor(p => p.UserId)
                  .Must(BeAValidUserID).WithMessage("User with specified ID doesnt exist");
            }
            if (checkOthers)
            {
                RuleFor(p => p.FirstName)
                  .Cascade(CascadeMode.StopOnFirstFailure)
                  .NotEmpty().WithMessage("{PropertyName} is Empty")
                  .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid")
                  .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

                RuleFor(p => p.LastName)
                  .Cascade(CascadeMode.StopOnFirstFailure)
                  .NotEmpty().WithMessage("{PropertyName} is Empty")
                  .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid")
                  .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

                RuleFor(p => p.PhoneNumber)
                    .Cascade(CascadeMode.StopOnFirstFailure)
                    .NotEmpty().WithMessage("{PropertyName} is Empty")
                    .Must(BeAValidNumber).WithMessage("{PropertyName} must be a number");

                RuleFor(p => p.EmailAddress)
                   .Cascade(CascadeMode.StopOnFirstFailure)
                   .NotEmpty().WithMessage("{PropertyName} is Empty")
                   .Must(BeAValidEmail).WithMessage("{PropertyName} is not a valid email address");
            }
        }

        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeAValidNumber(string number)
        {
            return Regex.Match(number, @"^[0-9]{1,10}$").Success;
        }

        public bool BeAValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool BeAValidUserID(int userId)
        {
            UserRepository userRepo = new UserRepository();
            var users = userRepo.GetAll();
            List<int> Ids = new List<int>();
            foreach (var item in users)
            {
                Ids.Add(item.UserId);
            }

            return Ids.Contains(userId);
        }
    }
}
