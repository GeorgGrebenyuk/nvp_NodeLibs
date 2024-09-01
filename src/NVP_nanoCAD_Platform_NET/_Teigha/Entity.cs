using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;
using System.Data;

namespace NVP_nanoCAD_Platform_NET._Teigha
{
    public class Entity_Helper : IEditAction
    {
        public enum Mode : int
        {
            Color,
            Layer,
            Linetype,
            LinetypeScale,
            Material,
            PlotStyleName,
            Transparency,
            Visible,
            //TODO: также для методов
        }
        public void SetData(ObjectId id, object mode_raw, object data)
        {
            Mode mode = (Mode)mode_raw;
            var doc = HostMgd.ApplicationServices.Document.Create(CommonData.ThisDocument);
            //Продумать с целевой БД
            using (Transaction acTrans = doc.Database.TransactionManager.StartTransaction())
            {
                Entity ent = acTrans.GetObject(id, OpenMode.ForWrite) as Entity;

                if (mode == Mode.Color) ent.Color = (Teigha.Colors.Color)data;
                else if (mode == Mode.Layer) ent.Layer = (string)data;
                else if (mode == Mode.Linetype) ent.Linetype = (string)data;
                else if (mode == Mode.LinetypeScale) ent.LinetypeScale = (double)data;
                else if (mode == Mode.Material) ent.Material = (string)data;
                else if (mode == Mode.PlotStyleName) ent.PlotStyleName = (string)data;
                else if (mode == Mode.Transparency) ent.Transparency = (Teigha.Colors.Transparency)data;
                else if (mode == Mode.Visible) ent.Visible = (bool)data;

                acTrans.Commit();
            }
        }

        public object GetData(ObjectId id, object modeRaw)
        {
            Mode mode = (Mode)modeRaw;
            object Data = null;
            var doc = HostMgd.ApplicationServices.Document.Create(CommonData.ThisDocument);
            //Продумать с целевой БД
            using (Transaction acTrans = doc.Database.TransactionManager.StartTransaction())
            {
                Entity ent = acTrans.GetObject(id, OpenMode.ForRead) as Entity;

                if (mode == Mode.Color) Data = ent.Color;
                else if (mode == Mode.Layer) Data = ent.Layer;
                else if (mode == Mode.Linetype) Data = ent.Linetype ;
                else if (mode == Mode.LinetypeScale) Data = ent.LinetypeScale;
                else if (mode == Mode.Material) Data = ent.Material;
                else if (mode == Mode.PlotStyleName) Data = ent.PlotStyleName;
                else if (mode == Mode.Transparency) Data = ent.Transparency;
                else if (mode == Mode.Visible) Data = ent.Visible;

                acTrans.Commit();
            }
            return Data;
        }
    }

    #region Конструкторы
    
    [NVP_Manifest(
        Text = "Возвращает Entity (режим чтения) по строковому значению Handle",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("dynamic", typeof(object))]
    public class Entity_Constructor : INode
    {
        public IntPtr _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            _o = _input0._o;

            return new NodeResult(this);
        }
    }
    #endregion

    #region Получение свойств
    [NVP_Manifest(
        Text = "Возвращает наименование слоя объекта",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Entity", typeof(object))]
    public class Get_Layer : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            var entId = (ObjectId)_input0._o;
            Entity_Helper h = new Entity_Helper();
            var data = h.GetData(entId, Entity_Helper.Mode.Layer);
            return new NodeResult(data);
        }
    }

    #endregion

    #region Установка свойств
    [NVP_Manifest(
    Text = "Задает наименование слоя объекту",
    CADType = "Nanocad",
    ViewType = "Modifier")]
    [NodeInput("Entity", typeof(object))]
    [NodeInput("Имя слоя", typeof(object))]
    public class Set_Layer : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            string _input1 = (string)inputs[1].Value;
            var entId = (ObjectId)_input0._o;
            Entity_Helper h = new Entity_Helper();
            h.SetData(entId, Entity_Helper.Mode.Layer, _input1);

            return new NodeResult(null);
        }
    }
    #endregion
}
