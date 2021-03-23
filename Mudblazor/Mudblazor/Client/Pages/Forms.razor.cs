using MudBlazor;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mudblazor.Client.Pages
{
    public partial class Forms
    {
        public bool Success { get; set; }
        public bool ShowInfo { get; set; } = true;
        public bool ShowWarning { get; set; } = true;
        public bool ShowSuccess { get; set; } = true;
        public bool ShowError { get; set; } = true;

        public string[] Errors { get; set; } = Array.Empty<string>();
        public MudTextField<string> MainPwField { get; set; }
        public MudForm Form { get; set; }


        private IEnumerable<string> PasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                yield return "Password is required!";
                yield break;
            }

            if (password.Length < 8)
                yield return "Password must be at least of length 8";
            if (!Regex.IsMatch(password, @"[A-Z]"))
                yield return "Password must contain at least one capital letter";
            if (!Regex.IsMatch(password, @"[a-z]"))
                yield return "Password must contain at least one lowercase letter";
            if (!Regex.IsMatch(password, @"[0-9]"))
                yield return "Password must contain at least one digit";
        }

        private string PasswordMatch(string arg)
        {
            if (MainPwField.Value != arg)
                return "Passwords don't match";
            return null;
        }

        private string CorrectBestTeam(string arg)
        {
            if (arg != "Red Bull")
                return "You've chosen the wrong favourite team";
            return null;
        }
    }
}
