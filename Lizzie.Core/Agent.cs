using Lizzie.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizzie.Core
{
    public class Agent : IAgent
    {

        #region [ IAgent ]

        private Mood agentMood = null;
        public virtual Mood AgentMood
        {
            get { return agentMood; }
            protected set
            {
                if (value == null)
                    throw new ArgumentNullException("AgentMood cannot be set to null!");
            }
        }

        private DateTime birthday;
        public virtual DateTime Birthday
        {
            get { return birthday; }
            set { if (value == null) birthday = DateTime.Today; else birthday = value; }
        }

        private string firstName;
        public virtual string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("FirstName cannot be null, whitespace or empty!");
                else
                    firstName = value;
            }
        }

        private Gender gender;
        public virtual Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string lastName;
        public virtual string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("FirstName cannot be null, whitespace or empty!");
                else
                    lastName = value;
            }
        }

        private string title;
        public virtual string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("FirstName cannot be null, whitespace or empty!");
                else
                    title = value;
            }
        }

        #endregion

        #region [ Construction ]

        public Agent(IKnownPerson person, Mood mood)
        {
            if (person == null)
                throw new ArgumentNullException("person");
            if (string.IsNullOrEmpty(person.FirstName) || string.IsNullOrWhiteSpace(person.FirstName))
                throw new NullReferenceException("person.FirstName");
            if (string.IsNullOrEmpty(person.LastName) || string.IsNullOrWhiteSpace(person.LastName))
                throw new NullReferenceException("person.LastName");
            if (string.IsNullOrEmpty(person.Title) || string.IsNullOrWhiteSpace(person.Title))
                throw new NullReferenceException("person.Title");
            if (person.Birthday == null)
                throw new NullReferenceException("person.Birthday");
            if (mood == null)
                throw new ArgumentNullException("mood");
            firstName = person.FirstName; lastName = person.LastName; birthday = person.Birthday; gender = person.Gender; title = person.Title;
            agentMood = mood;
        }

        public Agent(string firstName, string lastName, DateTime birthday, Gender gender, string title, Mood mood)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentNullException("firstName");
            if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException("lastName");
            if (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("title");
            if (birthday==null)
                throw new ArgumentNullException("birthday");
            if (mood == null)
                throw new ArgumentNullException("mood");
            this.firstName = firstName; this.lastName = lastName; this.birthday = birthday; this.gender = gender; this.title = title;
            agentMood = mood;
        }

        #endregion

    }
}
