using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_INF272Prac3.Models
{
	public class ErrorModel
	{
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}