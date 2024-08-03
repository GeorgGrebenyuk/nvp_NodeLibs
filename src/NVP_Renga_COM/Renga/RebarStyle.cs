using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.RebarStyle 
{

	[NVP_Manifest(
		Id = "BBB6232A-D1C7-499A-A2B4-8DE3E19A4002", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.RebarStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "_RebarStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarStyle_Constructor : INode 
	{
		public Renga.IRebarStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRebarStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EBF02B01-6FAC-49A8-843C-85BF39C0DC97", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.RebarStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "_RebarStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class RebarStyle_ConstructorCast : INode 
	{
		public Renga.IRebarStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRebarStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1C9BA356-3C50-4DB9-AA89-A5B970A2920A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "C8AEE541-BC1B-4FA2-A476-C30728F91D91", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "127594D2-D837-4D6E-AD65-EDB8D42F5C92", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.GradeName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "GradeName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GradeName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradeName);

		}
	}


	[NVP_Manifest(
		Id = "A9F30665-D61E-48BD-ABE8-A16422AE9806", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Id = "682F596A-00A7-460B-AB4E-A9B746C69ACC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.MaterialId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "MaterialId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MaterialId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaterialId);

		}
	}


	[NVP_Manifest(
		Id = "B536468F-0755-42E3-A2C2-F869AAFB4AEB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.RebarStyle.GradeTensileStrength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.RebarStyle", 
		NodeName = "GradeTensileStrength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("RebarStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GradeTensileStrength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GradeTensileStrength);

		}
	}
}
