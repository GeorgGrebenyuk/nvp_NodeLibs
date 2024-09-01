using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;


namespace NVP_nanoCAD_Platform_NET._Application.BlockTableRecord
{

    [NVP_Manifest(
        Text = "Инициализирует BlockTableRecord",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("dynamic", typeof(object))]
    public class BlockTableRecord_Constructor : INode
    {
        public IntPtr _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            _o = (_input0 as Teigha.DatabaseServices.BlockTableRecord).UnmanagedObject;

            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает Блок пространства модели в режиме чтения",
        CADType = "Nanocad",
        ViewType = "Data")]
    [NodeInput("Database", typeof(object))]
    public class ModelSpace_Constructor : INode
    {
        public IntPtr _o;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            Teigha.DatabaseServices.Database db = (Teigha.DatabaseServices.Database)_input0._o;

            using (Transaction acTrans = db.TransactionManager.StartTransaction())
            {
                BlockTable acBlkTbl;
                acBlkTbl = acTrans.GetObject(db.BlockTableId,
                                                OpenMode.ForRead) as BlockTable;

                // Open the Block table record Model space for write
                var _o_temp = acTrans.GetObject(acBlkTbl[Teigha.DatabaseServices.BlockTableRecord.ModelSpace],
                                                OpenMode.ForRead) as Teigha.DatabaseServices.BlockTableRecord;
                _o = _o_temp.UnmanagedObject;
            }
            return new NodeResult(this);
        }
    }



}
