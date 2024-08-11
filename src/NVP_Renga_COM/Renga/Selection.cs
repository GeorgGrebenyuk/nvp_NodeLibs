using NVP.API.Nodes;
using System;
using System.Collections;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Renga.ModelObject;

///<summary>
///
///</summary>
namespace Renga.Selection 
{
	



	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Selection_Constructor : INode 
	{
		public Renga.ISelection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ISelection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Selection_ConstructorCast : INode 
	{
		public Renga.ISelection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ISelection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Selection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetSelectedObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSelectedObjects();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Selection", typeof(object))]
	public class SetSelectedObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSelectedObjects();
			return null;
		}
	}


    [NVP_Manifest(
        Text = "Производит выборку объектов в пространстве модели по типу (интерфейсу)",
        ViewType = "Modifier")]
    [NodeInput("Model", typeof(object))]
    [NodeInput("enum_SelectionType", typeof(object))]
    public class GetObjectsFromModelByClass : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
			enum_SelectionType.SelectionType sel_type = (enum_SelectionType.SelectionType)inputs[1].Value;

            Renga.IModel model = _input0._i as Renga.IModel;
			var model_collection = model.GetObjects();

			List<dynamic> objects = new List<dynamic>();			

            for (int i = 0; i < model_collection.Count; i++)
			{
				var single_object = model_collection.GetByIndex(i);
				dynamic single_object2 = null;
				bool is_success = false;

                try
                {
                    single_object2 = single_object.GetInterfaceByName(sel_type.ToString());
                    is_success = true;
                }
                catch { }
                
                if (is_success)
                {
                    switch (sel_type)
                    {
                        case enum_SelectionType.SelectionType.IBeamParams:
                            //single_object2 = single_object.GetInterfaceByName("Renga.IBeamParams");
                            if (single_object2 != null)
                            {
                                var item = new BeamParams.BeamParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IColumnParams:
                            //single_object2 = single_object as Renga.IColumnParams;
                            if (single_object2 != null)
                            {
                                var item = new ColumnParams.ColumnParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IDoorParams:
                            //single_object2 = single_object as Renga.IDoorParams;
                            if (single_object2 != null)
                            {
                                var item = new DoorParams.DoorParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IFloorParams:
                            //single_object2 = single_object.GetInterfaceByName("IFloorParams");
                            //single_object2 = single_object as Renga.IFloorParams;
                            if (single_object2 != null)
                            {
                                var item = new FloorParams.FloorParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.ILevelObject:
                            //single_object2 = single_object as Renga.ILevelObject;
                            if (single_object2 != null)
                            {
                                var item = new LevelObject.LevelObject_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.ILine3DParams:
                            //single_object2 = single_object as Renga.ILine3DParams;
                            if (single_object2 != null)
                            {
                                var item = new Line3DParams.Line3DParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IModelObject:
                            //single_object2 = single_object as Renga.IModelObject;
                            if (single_object2 != null)
                            {
                                var item = new ModelObject.ModelObject_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IObjectOnRoutePlacement:
                            //single_object2 = single_object as Renga.IObjectOnRoutePlacement;
                            if (single_object2 != null)
                            {
                                var item = new ObjectOnRoutePlacement.ObjectOnRoutePlacement_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IObjectReinforcementModel:
                            //single_object2 = single_object as Renga.IObjectReinforcementModel;
                            if (single_object2 != null)
                            {
                                var item = new ObjectReinforcementModel.ObjectReinforcementModel_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IObjectWithLayeredMaterial:
                            //single_object2 = single_object as Renga.IObjectWithLayeredMaterial;
                            if (single_object2 != null)
                            {
                                var item = new ObjectWithLayeredMaterial.ObjectWithLayeredMaterial_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IObjectWithMark:
                            //single_object2 = single_object as Renga.IObjectWithMark;
                            if (single_object2 != null)
                            {
                                var item = new ObjectWithMark.ObjectWithMark_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IObjectWithMaterial:
                            //single_object2 = single_object as Renga.IObjectWithMaterial;
                            if (single_object2 != null)
                            {
                                var item = new ObjectWithMaterial.ObjectWithMaterial_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IObjectWithPorts:
                            //single_object2 = single_object as Renga.IObjectWithPorts;
                            if (single_object2 != null)
                            {
                                var item = new ObjectWithPorts.ObjectWithPorts_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IOpeningParams:
                            //single_object2 = single_object as Renga.IOpeningParams;
                            if (single_object2 != null)
                            {
                                var item = new OpeningParams.OpeningParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IPortDuctParams:
                            //single_object2 = single_object as Renga.IPortDuctParams;
                            if (single_object2 != null)
                            {
                                var item = new PortDuctParams.PortDuctParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IPortPipeParams:
                            //single_object2 = single_object as Renga.IPortPipeParams;
                            if (single_object2 != null)
                            {
                                var item = new PortPipeParams.PortPipeParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IRouteParams:
                            //single_object2 = single_object as Renga.IRouteParams;
                            if (single_object2 != null)
                            {
                                var item = new RouteParams.RouteParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IWallParams:
                            //single_object2 = single_object as Renga.IWallParams;
                            if (single_object2 != null)
                            {
                                var item = new WallParams.WallParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                        case enum_SelectionType.SelectionType.IWindowParams:
                            //single_object2 = single_object as Renga.IWindowParams;
                            if (single_object2 != null)
                            {
                                var item = new WindowParams.WindowParams_Constructor();
                                item._i = single_object2;
                                objects.Add(item);
                            }
                            break;
                    }
                }
                
            }
            return new NodeResult(objects);
        }
    }


    [NVP_Manifest(
        Text = "Осществляет выбор объектов модели в виде списка ModelObject_Constructor для заданного типа объекта",
        ViewType = "Modifier")]
    [NodeInput("Model", typeof(object))]
    [NodeInput("Renga.ObjectTypes", typeof(Guid))]
    public class GetObjectsFromModelByType : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            Guid sel_type = (Guid)inputs[1].Value;

            Renga.IModel model = _input0._i as Renga.IModel;
            var model_collection = model.GetObjects();

            List<ModelObject_Constructor> objects = new List<ModelObject_Constructor>();

            for (int i = 0; i < model_collection.Count; i++)
            {
                var single_object = model_collection.GetByIndex(i);

                if (single_object.ObjectType.Equals(sel_type))
                {
                    ModelObject_Constructor o = new ModelObject_Constructor();
                    o._i = single_object;
                    objects.Add(o);
                }
            }
            return new NodeResult(objects);
        }
    }

    [NVP_Manifest(
        Text = "Осществляет выбор объектов модели в виде списка ModelObject_Constructor для заданных типов объектов",
        ViewType = "Modifier")]
    [NodeInput("Model", typeof(object))]
    [NodeInput("Список Renga.ObjectTypes", typeof(object))]
    public class GetObjectsFromModelByTypes : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            IList sel_types = (IList)inputs[1].Value;

            Renga.IModel model = _input0._i as Renga.IModel;
            var model_collection = model.GetObjects();

            List<ModelObject_Constructor> objects = new List<ModelObject_Constructor>();

            for (int i = 0; i < model_collection.Count; i++)
            {
                var single_object = model_collection.GetByIndex(i);

                foreach (var id in sel_types)
                {
                    if (single_object.ObjectType.Equals(id))
                    {
                        ModelObject_Constructor o = new ModelObject_Constructor();
                        o._i = single_object;
                        objects.Add(o);
                    }
                }
            }
            return new NodeResult(objects);
        }
    }

}
