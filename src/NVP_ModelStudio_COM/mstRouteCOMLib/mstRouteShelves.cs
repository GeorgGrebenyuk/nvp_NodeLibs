using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace mstRouteCOMLib.mstRouteShelves 
{

	[NVP_Manifest(
		Id = "8072BA58-5571-4812-B80C-B02E783158AE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelves.mstRouteShelves_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelves", 
		NodeName = "_mstRouteShelves_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRouteShelves_Constructor : INode 
	{
		public mstRouteCOMLib.ImstRouteShelves _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstRouteCOMLib.ImstRouteShelves;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3D29AA93-35BB-4A82-9A69-9E740762FFDE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelves.mstRouteShelves_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelves", 
		NodeName = "_mstRouteShelves_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstRouteShelves_ConstructorCast : INode 
	{
		public mstRouteCOMLib.ImstRouteShelves _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstRouteCOMLib.ImstRouteShelves;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "28154680-6B1C-46F9-996C-2EB486857872", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelves.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelves", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelves", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Id = "BDEB22B0-4166-487C-A1A1-EFA5B9F7B54B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelves.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelves", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelves", typeof(object))]

	///<summary>
	///property Count
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "C164A636-360E-4FBC-B773-17A57CEBE0BA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelves.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelves", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Add", 
		ViewType = "Data")]
	[NodeInput("mstRouteShelves", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Width", typeof(System.Double))]
	[NodeInput("Height", typeof(System.Double))]
	[NodeInput("Offset", typeof(System.Double))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///method Add
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Id = "962C1A74-B151-4A08-A62A-4B03CE64B8C7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstRouteCOMLib.mstRouteShelves.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstRouteCOMLib.mstRouteShelves", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Remove", 
		ViewType = "Modifier")]
	[NodeInput("mstRouteShelves", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method Remove
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value);
			return null;
		}
	}
}
