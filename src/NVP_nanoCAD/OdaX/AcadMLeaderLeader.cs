using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///AutoCAD Interface for Multi-Leader's Leader Line
///</summary>
namespace OdaX.AcadMLeaderLeader 
{

	[NVP_Manifest(
		Id = "9A5914A6-A689-4C87-BDE1-1051F2154227", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.AcadMLeaderLeader_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "_AcadMLeaderLeader_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderLeader_Constructor : INode 
	{
		public OdaX.IAcadMLeaderLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLeaderLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EAB59F95-85A9-4E18-A8C9-EB0AF092AC85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.AcadMLeaderLeader_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "_AcadMLeaderLeader_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderLeader_ConstructorCast : INode 
	{
		public OdaX.IAcadMLeaderLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLeaderLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BBA78DAF-85E2-4E89-A25A-5B843915BAD7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.LeaderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "LeaderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the leader type", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the leader type
	///</summary>
	public class LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderType);

		}
	}


	[NVP_Manifest(
		Id = "B7BE9039-BAC0-4AE9-B0FA-FADCF822FA0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_LeaderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_LeaderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the leader type", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("OdaX.AcMLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies the leader type
	///</summary>
	public class Set_LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderType = ((OdaX.AcMLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4DDA311-F512-4FBB-B393-A4B2193077F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.LeaderLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "LeaderLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of the leader lines", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the color of the leader lines
	///</summary>
	public class LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineColor);

		}
	}


	[NVP_Manifest(
		Id = "3AB42A4B-0D32-4325-AE43-E2D3A8362620", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_LeaderLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_LeaderLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of the leader lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies the color of the leader lines
	///</summary>
	public class Set_LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "939C0942-62FE-47C7-A673-8F38740FE25E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.LeaderLineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "LeaderLineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of leader lines", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the linetype of leader lines
	///</summary>
	public class LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineType);

		}
	}


	[NVP_Manifest(
		Id = "A2CAA8FF-DECC-4ADD-9669-86CDC3C32DE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_LeaderLineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_LeaderLineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of leader lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Linetype", typeof(System.Object))]

	///<summary>
	///Specifies the linetype of leader lines
	///</summary>
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7EFE2517-33B5-41B5-B276-522CB879397B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.LeaderLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "LeaderLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the line weight of leader lines", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the line weight of leader lines
	///</summary>
	public class LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "81180D57-D2A1-42A6-9012-BE75DE8A59BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_LeaderLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_LeaderLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the line weight of leader lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies the line weight of leader lines
	///</summary>
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "15C11A19-C015-4F3E-993F-682604C7504A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.ArrowheadType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "ArrowheadType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the type of leader arrowhead", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the type of leader arrowhead
	///</summary>
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	[NVP_Manifest(
		Id = "256E4C50-A106-49AB-9B66-2845B9ADDDA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_ArrowheadType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_ArrowheadType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the type of leader arrowhead", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies the type of leader arrowhead
	///</summary>
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6E360455-00B0-4C74-AFF4-F34D1263B63D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the size of leader arrowhead", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the size of leader arrowhead
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Id = "8EB73324-AC25-49F0-A57A-1AAD96B48E93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_ArrowheadSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_ArrowheadSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the size of leader arrowhead", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies the size of leader arrowhead
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A4E58E5E-0131-4261-8B30-3486BBF7880B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.ArrowheadBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "ArrowheadBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the block to use as the custom arrowhead for leader lines of multileader", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the block to use as the custom arrowhead for leader lines of multileader
	///</summary>
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	[NVP_Manifest(
		Id = "1A61BA34-986F-41AB-98FC-69E3C731477C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderLeader.Set_ArrowheadBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderLeader", 
		NodeName = "Set_ArrowheadBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the block to use as the custom arrowhead for leader lines of multileader", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies the block to use as the custom arrowhead for leader lines of multileader
	///</summary>
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1].Value;
			return null;
		}
	}
}
