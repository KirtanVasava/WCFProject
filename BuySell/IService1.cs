
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BuySell
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<Item> GetItem();


        [OperationContract]
        void Add(Item obj);


        [OperationContract]
        void Update(Item obj);

        [OperationContract]
        void Delete(int id);




    }

    [DataContract]
    public class Item
    {
        [Required]
        [Key]
        [DataMember]
        public int id { get; set; }

        [Required]
        [DataMember]
        public string Iname { get; set; }

        [Required]
        [DataMember]
        public int Prize { get; set; }


    }
}
