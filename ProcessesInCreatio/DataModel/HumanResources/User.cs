using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessesInCreatio.DataModel
{
    public class User : Employee
    {
        /// <summary> Время регистрации пользователя </summary>
        public DateTime UserRegistrationTime { get; private set; }

        /// <summary> Время блокировки пользователя </summary>
        public DateTime? UserBlockingTime { get; set; }

        /// <summary> Является ли пользователь заблокированным </summary>
        public Boolean IsUserBlocked { get; set; }

        /// <summary> Логин пользователя </summary>
        public String UserLogin { get; set; }

        /// <summary> Хеш пароля пользователя </summary>
        public String UserPasswordHash { get; set;  }
    }
}
