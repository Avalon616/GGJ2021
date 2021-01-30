using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    [CreateAssetMenu(fileName ="NewSystem", menuName ="ScripObj/System")]
    public class System : ScriptableObject
    {
        public string DisplayName;
        public List<Action> actions;
        public GameObject AppearenceObject;
    }
}
