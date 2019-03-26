using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.ViewModels
{
    public class GeneralInformationVM:BaseModelVM
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string SiteDetail { get; set; }
        public string SiteLogoPath { get; set; }
        public string SiteName { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Email { get; set; }
        public string AboutMe { get; set; }
        public string vision { get; set; }
        public string Mission { get; set; }
    }
}
