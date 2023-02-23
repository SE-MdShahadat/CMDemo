using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Shahadat";
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Shahadat", LastName = "Hossain" });
            People.Add(new PersonModel { FirstName = "Shifa", LastName = "Shahrin" });
            People.Add(new PersonModel { FirstName = "Shahraan", LastName = "Ibn Shahadat" });
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }
        public PersonModel Selectperson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => Selectperson);
            }
        }


    }
}
