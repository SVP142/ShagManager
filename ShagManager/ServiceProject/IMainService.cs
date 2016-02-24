using ShagModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceProject
{
    [ServiceContract]
    public interface IServiceStudent
    {
        /// <summary>
        /// СТУДЕНТЫ
        /// </summary>
        ///
        [OperationContract]
        string GetStringForTest();

        [OperationContract]
        void GetStudents();

        [OperationContract]
        void GetParents();

        [OperationContract]
        void GetParent();

        [OperationContract]
        void AddPotentialStudent(Student student);

        [OperationContract]
        void RegistrStudent();

        [OperationContract]
        void RemoveStudent();

        [OperationContract]
        void ModifyStudent();

        /// <summary>
        /// ЗАДАЧИ
        /// </summary>

        [OperationContract]
        void GetWorkingTasks();

        [OperationContract]
        void AddTask();

        [OperationContract]
        void RemoveTask();

        /// <summary>
        /// МЕНЕДЖЕРЫ
        /// </summary>

        [OperationContract]
        void GetManagers();

        [OperationContract]
        void AddManager();

        [OperationContract]
        void ModifyManager();

        [OperationContract]
        void RemoveManager();

        /// <summary>
        /// АНАЛИТИКА
        /// </summary>

        [OperationContract]
        void GetManagerEfficiency(DateTime startDate, int length);

        [OperationContract]
        void GetManagerEfficiency(DateTime startDate, DateTime endDate);

        [OperationContract]
        void GetManagersEfficiency(/*Manager manager,*/ DateTime startDate, int length);

        [OperationContract]
        void GetManagersEfficiency(/*Manager manager,*/ DateTime startDate, DateTime endDate);

        [OperationContract]
        void SetReason(string reason);

        [OperationContract]
        void SetEducationalPlace(string name);
    }

    // Забиваем причины поступления в академию(админ)
    // Забивать уч заведения(админ)
    // 
}
