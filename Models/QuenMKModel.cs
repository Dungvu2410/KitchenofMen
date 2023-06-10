using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Websitekitchenofmen.Models
{
    public class QuenMKModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}