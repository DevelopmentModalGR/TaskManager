using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;
using TaskManager.Enums;
using TaskManager.ValueObjects;

namespace TaskManager.Models
{
    public class Profile : Entity
    {
        private List<Role> collaboratorRoles;


        #region Constructors
        public Profile(string profileName,List<Role> roles /*List<Department> department*/)
        {
            this.collaboratorRoles = new List<Role>();
            /*this.departments = new List<Department>();*/
            this.collaboratorRoles = roles;
            /*this.departments = department;*/
            Name = profileName;
        }
        #endregion

        #region Atributtes
        public string Name { get; set; }
        protected List<Role> CollaboratorRoles { get => collaboratorRoles; set => collaboratorRoles = value; }
        #endregion

        #region Methods      
        public void GetAllRoles()
        {
            
        }
        #endregion
    }
}
