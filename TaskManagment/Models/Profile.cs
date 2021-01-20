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
        public Profile(Role role)
        {
            this.collaboratorRoles = new List<Role>();
            collaboratorRoles.Add(role);
            IsAdmin = false;
        }

        public Profile(Role role, bool isAdmin)
        {
            this.collaboratorRoles = new List<Role>();
            collaboratorRoles.Add(role);
            IsAdmin = isAdmin;
        }
        #endregion

        #region Atributtes
        public bool  IsAdmin { get; private set; }
        internal List<Role> CollaboratorRoles { get => collaboratorRoles; set => collaboratorRoles = value; }
        #endregion

        #region Methods
        public void SetAsAdmin()
        {
            this.IsAdmin = true;
        }

        public void GetAllRoles()
        {
            
        }
        #endregion
    }
}
