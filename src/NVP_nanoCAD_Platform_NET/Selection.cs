using NVP.API.Nodes;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;
using NVP_nanoCAD_Platform_NET._Teigha;

using Teigha;



namespace NVP_nanoCAD_Platform_NET.Selection
{
    [NVP_Manifest(
        Text = "Возвращает Entity (режим чтения) по строковому значению Handle",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    [NodeInput("Handle", typeof(string))]
    [NodeInput("For read", typeof(bool))]
    public class GetEntityByHandle : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            string _input1 = inputs[1].Value.ToString();
            bool _input1_mode = (bool)inputs[2].Value;

            ObjectId id = new ObjectId(CommonData.GetObjectIdFromHandle(_input1));
            Entity_Constructor ent = new Entity_Constructor();
            ent._o = id.OldIdPtr;

            return new NodeResult(ent);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает Entity (режим чтения) по численному значению ObjectId",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    [NodeInput("ObjectId", typeof(long))]
    [NodeInput("Для чтения", typeof(bool))]
    public class GetEntityByObjectId : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            long _input1 = (long)inputs[1].Value;
            bool _input2_mode = (bool)inputs[2].Value;

            ObjectId id = new ObjectId(new IntPtr(_input1));
            Entity_Constructor ent = new Entity_Constructor();
            ent._o = id.OldIdPtr;

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает список Entity для заданного типа объекта",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    [NodeInput("Тип (ноды ObjectTypes)", typeof(string))]
    [NodeInput("Для чтения", typeof(bool))]
    public class GetEntitiesByClassType : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            bool openMode = (bool)inputs[1].Value;
            Type needClass = (Type)inputs[2].Value;
            List<Type> types = new List<Type>() { needClass };

            List<Entity_Constructor> to_out = new List<Entity_Constructor>();
            var ents = CommonData.GetObjectsByTypes(doc.Database, types, openMode, true) ;
            foreach (var ent in ents)
            {
                Entity_Constructor ent2 = new Entity_Constructor();
                ent2._o = ent;
                to_out.Add(ent2);
            }

            return new NodeResult(to_out);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает список Entity для заданных типов объектов",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    [NodeInput("Список типов (ноды ObjectTypes)", typeof(IList))]
    [NodeInput("Для чтения", typeof(bool))]
    public class GetEntitiesByClassTypes : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            bool openMode = (bool)inputs[1].Value;
            IList needClasses = (IList)inputs[2].Value;
            List<Type> types = needClasses.Cast<Type>().ToList();

            List<Entity_Constructor> to_out = new List<Entity_Constructor>();
            var ents = CommonData.GetObjectsByTypes(doc.Database, types, openMode, true);
            foreach (var ent in ents)
            {
                Entity_Constructor ent2 = new Entity_Constructor();
                ent2._o = ent;
                to_out.Add(ent2);
            }

            return new NodeResult(to_out);
        }
    }



}
