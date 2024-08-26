using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;
using ncCommon;

namespace Teigha
{
    [NVP_Manifest(
        Text = "Возвращает Entity (режим чтения) по строковому значению Handle",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("dynamic", typeof(string))]
    public class Entity_Constructor : INode
    {
        public Teigha.DatabaseServices.Entity _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            _o = _input0._o as Teigha.DatabaseServices.Entity;

            return new NodeResult(this);
        }
    }

    
}
