using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Arc2D 
{

	[NVP_Manifest(
		Id = "20348846-C7ED-40D8-B109-42A1E9E6CB36", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.Arc2D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "_Arc2D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc2D_Constructor : INode 
	{
		public Renga.IArc2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IArc2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A10CBBF7-0DBF-46E2-A68E-2DDC533D3B72", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.Arc2D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "_Arc2D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc2D_ConstructorCast : INode 
	{
		public Renga.IArc2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IArc2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A340EF1C-ECEF-4EE2-957A-A6482E24F170", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetPlacement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetPlacement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetPlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlacement);

		}
	}


	[NVP_Manifest(
		Id = "389E9707-F994-4CCC-8B4B-2E3044D27272", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadius);

		}
	}


	[NVP_Manifest(
		Id = "69937403-7634-4CE9-9D88-F8253AC666F8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetRadiusA", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetRadiusA", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadiusA : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadiusA);

		}
	}


	[NVP_Manifest(
		Id = "487B2E00-4D84-45D6-AC3A-435D5D244252", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetRadiusB", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetRadiusB", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadiusB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadiusB);

		}
	}


	[NVP_Manifest(
		Id = "EBBCB166-52B0-4331-8348-8B17298609DD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetBeginAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetBeginAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginAngle);

		}
	}


	[NVP_Manifest(
		Id = "A8092348-1B57-4043-8F04-1EFB3508B5F1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetEndAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetEndAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndAngle);

		}
	}


	[NVP_Manifest(
		Id = "668A7459-3C83-4592-8F8C-B6384D7F9A57", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetBeginGlobalAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetBeginGlobalAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginGlobalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginGlobalAngle);

		}
	}


	[NVP_Manifest(
		Id = "D03479C6-0C88-4E70-B304-539A29944B84", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetEndGlobalAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetEndGlobalAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndGlobalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndGlobalAngle);

		}
	}


	[NVP_Manifest(
		Id = "CE80F934-2CCD-4779-86CB-2D109EB0DF41", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.IsCircular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "IsCircular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsCircular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCircular);

		}
	}


	[NVP_Manifest(
		Id = "DEBD7602-6DF5-4752-9FA4-AEAE8DFA29B1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.IsClockwise", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "IsClockwise", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsClockwise : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsClockwise);

		}
	}


	[NVP_Manifest(
		Id = "DFBA046B-3767-494D-8CBE-5558ADCD00CA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Arc2D.GetCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Arc2D", 
		NodeName = "GetCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenter);

		}
	}
}
