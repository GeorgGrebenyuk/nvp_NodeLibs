using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrReinfSpiral Interface
///</summary>
namespace ironObjComLib.WrReinfSpiral 
{

	[NVP_Manifest(
		Id = "BEE2B81F-85EA-4331-A4C5-15C1C33278C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.WrReinfSpiral_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "_WrReinfSpiral_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfSpiral_Constructor : INode 
	{
		public ironObjComLib.IWrReinfSpiral _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrReinfSpiral;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BC3B5FF7-D9CA-439E-B7B0-DC3A792981B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.WrReinfSpiral_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "_WrReinfSpiral_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfSpiral_ConstructorCast : INode 
	{
		public ironObjComLib.IWrReinfSpiral _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrReinfSpiral;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "921DB480-C567-419C-B382-37A8ADFBC3D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "0A11A2B4-84FC-4EBF-A799-E813F2E36D87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "158328C8-9A97-4FA9-B8D5-6AFC5BEF6B53", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Parent
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Id = "42FF10C8-4D01-42AF-A841-2193EF1E9741", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Parent
	///</summary>
	public class Set_Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A88DEE19-BAA9-4E4F-B3FC-88FA55B1E905", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Name
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
		Id = "A33C7137-E95B-4B55-A3DF-7370C0DB67E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FF908CF-09F8-421D-9549-254197BD09EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Class", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Class
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Id = "25FAB71C-86CF-4A60-81BB-060236FBCBBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Class", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Class
	///</summary>
	public class Set_Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Class = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AC01FE8B-4AC7-4AAF-8E8A-9F8095F557BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Diameter", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Diameter
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
		Id = "D5A333A4-96F8-4DF7-87A2-B34E84C6B8E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Diameter", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Diameter
	///</summary>
	public class Set_Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Diameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1BCB68E5-BC55-49C2-AF98-0CB3CB716E9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Height", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Height
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "F51AAF3C-6141-4090-A0AD-D9BA1FB5B21F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Height", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Height
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3E7B622A-1E33-42DB-9BD2-0F5A21771B90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Details", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Details", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Details", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Details
	///</summary>
	public class Details : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Details);

		}
	}


	[NVP_Manifest(
		Id = "65A6ACB5-DFB3-45A6-8F2E-BCE6877F8503", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Details", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Details", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Details", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Details
	///</summary>
	public class Set_Details : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Details = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1B0187D1-D88F-451C-AC7D-AACF8CABC352", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Radius", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Radius
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Id = "A19297DE-4F2E-42AA-B046-AF25AC1B7528", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Radius", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Radius
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C4F3196-BAA1-403C-8268-F00FA1EE2B38", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Step", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Step", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Step", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Step
	///</summary>
	public class Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Step);

		}
	}


	[NVP_Manifest(
		Id = "5FC170D1-3702-4204-9CB0-5BD923B1FA6A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Step", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Step", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Step", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Step
	///</summary>
	public class Set_Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Step = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "60C4E251-2034-4DAB-A250-54C49C3097CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.RunWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "RunWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RunWeight", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property RunWeight
	///</summary>
	public class RunWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RunWeight);

		}
	}


	[NVP_Manifest(
		Id = "70E0F48B-C005-45DF-B2FD-202187177B43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_RunWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_RunWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RunWeight", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RunWeight
	///</summary>
	public class Set_RunWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RunWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D5820053-A3C8-45D9-AC13-D254B69BBEDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.SecArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "SecArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SecArea", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property SecArea
	///</summary>
	public class SecArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecArea);

		}
	}


	[NVP_Manifest(
		Id = "41B5336B-2130-487F-937B-9BCA7123A63F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_SecArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_SecArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property SecArea", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property SecArea
	///</summary>
	public class Set_SecArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecArea = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "178641DC-5187-4FD0-BCD8-9B6127692D40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Length
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Id = "4DB62610-412E-484E-8F3D-4B4A49D23711", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Set_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Set_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfSpiral", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Length
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8587E2FB-E0E9-4D80-8DF8-F753558030D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfSpiral.Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfSpiral", 
		NodeName = "Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Weight", 
		ViewType = "Data")]
	[NodeInput("WrReinfSpiral", typeof(object))]

	///<summary>
	///property Weight
	///</summary>
	public class Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weight);

		}
	}
}
