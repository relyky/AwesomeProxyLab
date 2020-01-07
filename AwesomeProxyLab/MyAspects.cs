using AwesomeProxy;
using AwesomeProxy.FilterAttribute;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace AwesomeProxyLab
{
    class LogAspectAttribute : AopBaseAttribute
    {
        public string LogTag { get; set; }

        public override void OnExecuting(ExecutingContext context)
        {
            string tag = "nil";
            if (LogTag != null) {
                object tmp = CallContext.GetData(LogTag); // CallContext 怪東西。不用也吧。
                if (tmp != null)
                    tag = tmp.ToString();
            }

            Console.WriteLine($"OnExecuting >> {context.MethodName} {tag}");
        }

        public override void OnExecuted(ExecutedContext context)
        {
            Console.WriteLine($"OnExecuted >> {context.MethodName}");
        }

        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine($"OnException >> {context.MethodName}");
        }
    }
}