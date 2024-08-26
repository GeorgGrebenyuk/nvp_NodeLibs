using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;
using ncCommon;
using Application.Database;


namespace Application.Document
{
    [NVP_Manifest(
        Text = "Возвращает текущий активный документ (модель) nanoCAD",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class DocumentCurrent_Constructor : INode
    {
        public HostMgd.ApplicationServices.Document _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            _o = CommonData.ThisDocument;
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает COM-оболочку документа (nanoCAD.AcadDocument) для пакета NVP_nanoCAD_COM",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    public class Get_COM_AcadDocument : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            return new NodeResult(doc.AcadDocument);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает наименование документа",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    public class Get_Name : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            return new NodeResult(doc.Name);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает Базу данных модели (Database) в виде нода Database_Constructor",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Document", typeof(object))]
    public class Get_Database : INode
    {
        public HostMgd.ApplicationServices.Document _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            HostMgd.ApplicationServices.Document doc = (HostMgd.ApplicationServices.Document)_input0._o;

            Database_Constructor db_C = new Database_Constructor();
            db_C._o = doc.Database;

            return new NodeResult(db_C);
        }
    }
}
