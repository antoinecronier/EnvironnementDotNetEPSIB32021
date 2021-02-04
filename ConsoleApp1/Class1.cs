using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        #region Inline prop
        private long id;

        public long Id { get => this.id; set => this.id = value*2; }
        #endregion

        #region propfull
        /// <summary>
        /// Propfull class var
        /// </summary>
        private string firstname;

        /// <summary>
        /// propfull prop
        /// </summary>
        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (value.StartsWith("A"))
                {
                    firstname = value;
                }
            }
        }
        #endregion

        #region Auto property
        /// <summary>
        /// Auto property
        /// </summary>
        public string Lastname { get; private set; }
        #endregion



        #region Java exemple
        public void SetId(long id)
        {
            this.Id = id;
        }

        public long GetId()
        {
            return this.Id;
        }
        #endregion

    }
}
