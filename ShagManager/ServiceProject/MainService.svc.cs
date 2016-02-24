using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ShagManager;
using ShagModel;

namespace ServiceProject
{
    public class ServiceStudent : IServiceStudent
    {
        /* Получить всех студентов */
        public void GetStudents()
        {
            throw new NotImplementedException();
        }

        /* Получить всех студентов которые учатся */
        public void GetStudyingStudents()
        {
            throw new NotImplementedException();
        }

        /* Получить всех родителей */
        public void GetParents()
        {
            throw new NotImplementedException();
        }

        /* Получить родителя */
        public void GetParent()
        {
            throw new NotImplementedException();
        }

        /* Добавление студента с первоначальными данными */
        public void AddPotentialStudent(Student student)
        {
            using (var db = new ManagerContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        /* Заполнение остальных данных */
        public void RegistrStudent()
        {
            throw new NotImplementedException();
        }

        /* Удаление студента */
        public void RemoveStudent()
        {
            throw new NotImplementedException();
        }

        /* Изменение студента */
        public void ModifyStudent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /* Вернуть всех менеджеров */
        public void GetManagers()
        {
            throw new NotImplementedException();
        }

        /* Добавить менеджеров */
        public void AddManager()
        {
            throw new NotImplementedException();
        }

        /* Изменить менеджера */
        public void ModifyManager()
        {
            throw new NotImplementedException();
        }

        /* Удалить менеджера */
        public void RemoveManager()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /* Вернуть все задачи */
        public void GetWorkingTasks()
        {
            throw new NotImplementedException();
        }

        public void AddTask()
        {
            throw new NotImplementedException();
        }

        public void RemoveTask()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        public void GetManagerEfficiency(DateTime startDate, int length)
        {
            throw new NotImplementedException();
            /*  Получаем список выполненных задач
             *  за время с startDate и length количество дней
                по определенному менеджеру */
        }

        public void GetManagerEfficiency(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
            /*  Получаем список выполненных задач
             *  за время с startDate до endDate
                по определенному менеджеру */
        }

        public void GetManagersEfficiency(DateTime startDate, int length)
        {
            throw new NotImplementedException();
            /*  Получаем список выполненных задач
             *  за время с startDate и length количество дней
             *  по всем менеджерам */
        }

        public void GetManagersEfficiency(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
            /*  Получаем список выполненных задач
             *  за время с startDate до endDate
             *  по всем менеджеру */
        }

        public void SetReason(string reason)
        {
            throw new NotImplementedException();
            /*  Добавляем виды получения информации
             *  об академии  */
        }

        public void SetEducationalPlace(string name)
        {
            throw new NotImplementedException();
            /*  Добавляем учебные заведения */
        }
    }
}
