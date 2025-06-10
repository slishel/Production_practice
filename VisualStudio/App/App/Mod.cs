using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Mod
    {
        public class User
        {
            public int id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string nameRole { get; set; } // "Admin", "Executor", "Client"
            public string FIO { get; set; }

        }

      
        // Класс для представления заявки
        // Класс для представления заявки
        public class Request
        {
            public int id { get; set; } // Номер заявки
            public DateTime CreationDate { get; set; }
            public string EquipmentName { get; set; }
            public string FaultType { get; set; } // Тип неисправности
            public string Description { get; set; }
            public int idUser { get; set; } // Имя клиента
            public string Status { get; set; } // "В ожидании", "В работе", "Выполнено"
           
            public DateTime? DateCompleted { get; set; }
        }
    }
}
