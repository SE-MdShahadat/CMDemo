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
    public class ShellViewModel : Conductor<object>
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
        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }
        public bool CanClearText(string firstName, string lastName)
        {
            //return !String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName);
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }else return true;
        }
        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }
        public void LoadPageOne()
        {
            //ActivateItem(new FirstChildViewModel());
            //ActivateItem();
        }

        //private FirstChildViewModel ActivateItem(FirstChildViewModel firstChildViewModel)
        //{
        //    return new FirstChildViewModel();
        //}

        public void LoadPageTwo()
        {
            //ActivateItem(new SecondChildViewModel());
            //ActivateItem();
        }

        //private SecondChildViewModel ActivateItem(SecondChildViewModel secondChildViewModel)
        //{
        //    return new SecondChildViewModel();
        //}
    }
}
