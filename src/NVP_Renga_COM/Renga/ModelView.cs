using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ModelView 
{

	[NVP_Manifest(
		Id = "8AA87BC2-858B-4678-B0F1-FDEC99FD0E88", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.ModelView_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "_ModelView_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelView_Constructor : INode 
	{
		public Renga.IModelView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModelView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9698DDF4-B306-4198-87D8-E5819D2A560A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.ModelView_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "_ModelView_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelView_ConstructorCast : INode 
	{
		public Renga.IModelView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModelView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C60E4300-4333-4FAA-A016-39E9FFE8D309", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.SetObjectsVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "SetObjectsVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SetObjectsVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetObjectsVisibility();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C37E7683-C7CC-4F3A-8853-0716F2340D31", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.IsObjectVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "IsObjectVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelView", typeof(object))]
	[NodeInput("objectId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class IsObjectVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsObjectVisible(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "BE8415FF-6965-4F57-9468-630FA37D29C3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.SetObjectsVisualStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "SetObjectsVisualStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SetObjectsVisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetObjectsVisualStyle();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C3EC6476-9720-4D7E-8460-ABEC1F2138CF", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.GetObjectVisualStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "GetObjectVisualStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelView", typeof(object))]
	[NodeInput("objectId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetObjectVisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjectVisualStyle(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7EADEBAA-3ED4-4FA5-83A7-32FEC1016A5A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.Set_VisualStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "Set_VisualStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]
	[NodeInput("Renga.VisualStyle", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VisualStyle = ((Renga.VisualStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BB433E62-5DD5-4F63-BD41-BDD5523020DD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.VisualStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "VisualStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VisualStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VisualStyle);

		}
	}


	[NVP_Manifest(
		Id = "5BABA8C2-CFC1-4996-B752-47C931AE2C29", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ModelView.ShowObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ModelView", 
		NodeName = "ShowObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ModelView", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShowObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowObjects();
			return null;
		}
	}
}
