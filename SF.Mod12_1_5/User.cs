using System;
using System.Threading;

namespace SF.Mod12_1_5
{
    /// <summary>
    /// Класс пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Признак есть ли премиум-подписка ?
        /// </summary>
        public bool IsPremium { get; set; }
    }
}
