

namespace Automation_Framework.Tests.Models
{
    public class ProfileScreenLabels
    {
        public string profileTitleLabel { get; set; }
        public string firstNameLabel { get; set; }
        public string lastNameLabel { get; set; }
        public string emailLabel { get; set; }
        public string creditsLabel { get; set; }


        public ProfileScreenLabels(string profileTitleLabel, string firstNameLabel, string lastNameLabel, string emailLabel, string creditsLabel)
        {
            this.profileTitleLabel = profileTitleLabel;
            this.firstNameLabel = firstNameLabel;
            this.lastNameLabel = lastNameLabel;
            this.emailLabel = emailLabel;
            this.creditsLabel = creditsLabel;

        }
    }
}
