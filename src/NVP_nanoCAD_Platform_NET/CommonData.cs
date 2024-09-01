using HostMgd.ApplicationServices;
using Teigha.DatabaseServices;
using Teigha.Geometry;
using System;
using System.Collections.Generic;

namespace NVP_nanoCAD_Platform_NET
{
    public class CommonData
    {
        public static IntPtr ThisDocument
        {
            get
            {
                return HostMgd.ApplicationServices.Application.DocumentManager.MdiActiveDocument.UnmanagedObject;
            }
        }

        public static IntPtr GetObject(Database db, ObjectId id, bool modeRead, bool asEntity)
        {
            OpenMode _mode = OpenMode.ForRead;
            if (!modeRead) _mode = OpenMode.ForWrite;
            DBObject to_out = null;

            using (Transaction acTrans = db.TransactionManager.StartTransaction())
            {
                to_out = acTrans.GetObject(id, _mode);
                if (asEntity) to_out = to_out as Entity;

                acTrans.Commit();
            }

            return to_out.UnmanagedObject;
        }

        public static List<IntPtr> GetObjectsByTypes (Database db, List<Type> types, bool modeRead, bool asEntity)
        {
            OpenMode _mode = OpenMode.ForRead;
            if (!modeRead) _mode = OpenMode.ForWrite;
            List<IntPtr> to_out = new List<IntPtr>();

            using (Transaction acTrans = db.TransactionManager.StartTransaction())
            {
                // Open the Block table for read
                BlockTable acBlkTbl;
                acBlkTbl = acTrans.GetObject(db.BlockTableId,
                                                OpenMode.ForRead) as BlockTable;

                // Open the Block table record Model space for write
                BlockTableRecord acBlkTblRec;
                acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace],
                                                OpenMode.ForWrite) as BlockTableRecord;

                foreach (var oId in acBlkTblRec)
                {
                    var ent = acTrans.GetObject(oId, _mode);
                    if (asEntity) ent = ent as Entity;

                    if (types.Contains(ent.GetType())) to_out.Add(ent.UnmanagedObject);
                }
                acTrans.Commit();
            }

            return to_out;
        }

        public static IntPtr GetObjectIdFromHandle(string _handle)
        {
            //Convert Hexadecimal string to 64 bit integer
            long entityHandleLongInt = Convert.ToInt64(_handle, 16);

            //Create Handle from long integer
            Handle handle = new Handle(entityHandleLongInt);

            //Get Object Id for Handle
            ObjectId objectId = Document.Create(ThisDocument).Database.GetObjectId(false, handle, 0);

            return objectId.OldIdPtr;
        }
    }
}
