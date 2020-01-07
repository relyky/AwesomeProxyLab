using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AwesomeProxyLab
{
    class FooFormBiz : MarshalByRefObject
    {
        [LogAspect(LogTag = "Baz")]
        public FooFormData LoadFormData(string formNo)
        {
            return new FooFormData()
            {
                formNo = formNo,
                field01 = "I am field 01",
                field02 = DateTime.Now.Ticks % 10000,
                field03 = DateTime.Now
            };
        }

        [LogAspect]
        public string SaveFormData(FooFormData formData)
        {
            //...sims to save form data to database.
            return "SUCCESS";
        }
    }

    class FooFormData
    {
        public string formNo { get; set; }
        public string field01 { get; set; }
        public decimal field02 { get; set; }
        public DateTime field03 { get; set; }
    }
}