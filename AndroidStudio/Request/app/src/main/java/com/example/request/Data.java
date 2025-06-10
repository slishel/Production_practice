package com.example.request;

import java.util.ArrayList;
import java.util.List;

public class Data {

    public static class User {
        public int Id;
        public String Login;
        public String Password;

        public User(int id, String login, String password) {
            this.Id = id;
            this.Login = login;
            this.Password = password;
        }

        @Override
        public String toString() {
            return "User{" +
                    "Id=" + Id +
                    ", Login='" + Login + '\'' +
                    ", Password='" + Password + '\'' +
                    '}';
        }
    }

    public static class Request {
        public int Id;
        public String CreationDate;
        public String Equipment;
        public String FaultType;
        public String Description;
        public int ClientId;
        public String Status;
        public String DateCompleted;

        public Request(int id, String creationDate, String equipment, String faultType, String description, int clientId, String status, String dateCompleted) {
            this.Id = id;
            this.CreationDate = creationDate;
            this.Equipment = equipment;
            this.FaultType = faultType;
            this.Description = description;
            this.ClientId = clientId;
            this.Status = status;
            this.DateCompleted = dateCompleted;
        }

        @Override
        public String toString() {
            return "Request{" +
                    "Id=" + Id +
                    ", CreationDate='" + CreationDate + '\'' +
                    ", Equipment='" + Equipment + '\'' +
                    ", FaultType='" + FaultType + '\'' +
                    ", Description='" + Description + '\'' +
                    ", ClientId=" + ClientId +
                    ", Status='" + Status + '\'' +
                    ", DateCompleted='" + DateCompleted + '\'' +
                    '}';
        }
    }


    public static List<User> Users = new ArrayList<>();
    public static List<Request> Requests = new ArrayList<>();

    static {
        // Пример заполнения пользователей
        Users.add(new User(1, "Svetka", "user1234"));
        Users.add(new User(2, "trttt43", "fvvb00"));
        Users.add(new User(3, "Pasha", "iikklo8"));
        Users.add(new User(4, "Misha", "yyy5"));
        Users.add(new User(5, "OlIya", "776yhh"));



        // Пример заполнения заявок
        Requests.add(new Request(1, "2023-07-01", "Сервер", "Не работает", "Не можем запустить сервер, сразу выключается", 2, "В работе", ""));
        Requests.add(new Request(2, "2023-07-22", "Монитор", "Не включается", "Ни на что не реагирует", 2, "В ожидании", ""));
        Requests.add(new Request(3, "2023-07-12", "Телефон", "Нет изображения", "После включения нет изображения", 1, "Выполнено", "2025-04-13"));
        Requests.add(new Request(4, "2025-05-13", "Принтер", "Ошибка драйвера", "Перестал печатать", 3, "В ожидании", ""));
        Requests.add(new Request(5, "2023-02-10", "Сканер", "Не сканирует документы", "После нажатии кнопки ничего не происходит", 4, "В работе", ""));
        Requests.add(new Request(6, "2023-02-16", "Ноутбук	", "Проблемы с подключением к VPN", "Перестал работать без VPN, само подключение не работает", 3, "Выполнено", "2023-02-12"));
    }
}