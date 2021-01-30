using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName ="NewAction", menuName ="ScripObj/Action")]
    public class Action:ScriptableObject
    {
        public string DisplayName;

    }
}
