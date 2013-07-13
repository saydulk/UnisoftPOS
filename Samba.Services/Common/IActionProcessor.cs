﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Samba.Services.Common
{
    public interface IActionProcessor
    {
        string ActionType { get; }
        string ActionName { get; }
        object DefaultData { get; }
        ExpandoObject ParameterObject { get; }
        bool Handles(string actionType);
        void Process(ActionData actionData);
    }
}
