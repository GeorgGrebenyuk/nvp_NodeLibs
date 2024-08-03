using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Quantity 
{

	[NVP_Manifest(
		Id = "3F017C98-4721-4C9A-B3F3-CB13ECDE3DA4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.Quantity_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "_Quantity_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Quantity_Constructor : INode 
	{
		public Renga.IQuantity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IQuantity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "26AA36FE-B4A6-4A14-977C-0B6562CCDB54", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.Quantity_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "_Quantity_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Quantity_ConstructorCast : INode 
	{
		public Renga.IQuantity _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IQuantity;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FEECF535-111B-48A3-B733-8D98583701E0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.HasValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "HasValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}


	[NVP_Manifest(
		Id = "93B14341-D93E-40A9-A3DE-B853CBE374A1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "5CC83F6B-ED42-4262-A38C-24388DC9FC83", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.AsCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "AsCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AsCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsCount);

		}
	}


	[NVP_Manifest(
		Id = "A722534A-6796-46F9-ACD1-AE693BBFBA91", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.AsLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "AsLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.LengthUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsLength(((Renga.LengthUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "420236C3-0465-408F-B779-F0F6432BE9D4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.AsArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "AsArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.AreaUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsArea(((Renga.AreaUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "4779ECBB-ED0C-4155-A336-D6C676C576E1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.AsVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "AsVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.VolumeUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsVolume(((Renga.VolumeUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "C9CF0127-7137-4958-80BD-0E3A02C03F81", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Quantity.AsMass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Quantity", 
		NodeName = "AsMass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Quantity", typeof(object))]
	[NodeInput("Renga.MassUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AsMass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AsMass(((Renga.MassUnit)inputs[1].Value)));

		}
	}
}
