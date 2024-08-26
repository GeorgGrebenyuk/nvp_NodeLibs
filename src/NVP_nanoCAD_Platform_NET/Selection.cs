using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;
using ncCommon;
using Application.Database;
using Teigha;
using System.Security.Cryptography;


namespace Selection
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

            ObjectId id = CommonData.GetObjectIdFromHandle(_input1);
            Entity_Constructor ent = new Entity_Constructor();
            ent._o = CommonData.GetObject(doc.Database, id, _input1_mode, true) as Teigha.DatabaseServices.Entity;

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
            ent._o = CommonData.GetObject(doc.Database, id, _input2_mode, true) as Teigha.DatabaseServices.Entity;

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает список Entity для заданного названия типа",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    [NodeInput("Имя класса", typeof(string))]
    [NodeInput("Для чтения", typeof(bool))]
    public class GetEntitiesByClassName : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            bool openMode = (bool)inputs[1].Value;
            string needClass = (string)inputs[2].Value;
            List<string> types = new List<string>() { needClass };

            List<Entity_Constructor> to_out = new List<Entity_Constructor>();
            var ents = CommonData.GetObjectsByTypes(doc.Database, types, openMode, true) ;
            foreach (var ent in ents)
            {
                Entity_Constructor ent2 = new Entity_Constructor();
                ent2._o = ent as Teigha.DatabaseServices.Entity;
                to_out.Add(ent2);
            }

            return new NodeResult(to_out);
        }
    }



}
