using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface for a Light entity
///</summary>
namespace OdaX.OdaLight 
{

	[NVP_Manifest(
		Id = "927CF5DC-B5CF-49E4-834F-6E94BCBA73BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.OdaLight_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "_OdaLight_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLight_Constructor : INode 
	{
		public OdaX.IOdaLight _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaLight;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "30D745BF-334F-4B92-BA57-1553E9652875", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.OdaLight_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "_OdaLight_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLight_ConstructorCast : INode 
	{
		public OdaX.IOdaLight _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaLight;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9AAB4D8A-F953-4C27-81D2-1949F8E36BDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

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
		Id = "F7DAA492-4901-4CF1-ACCD-3E0E4BE6CA7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
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
		Id = "1DD8A424-D08A-487B-8F41-4B2B2B5BEB62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.LightType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "LightType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LightType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LightType);

		}
	}


	[NVP_Manifest(
		Id = "5A9EB72F-9BF5-4165-B2D9-1F9B6E7B6BD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_LightType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_LightType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_LightType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LightType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D4582BF3-7F29-4D71-B2BD-71DE4F77F17F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Status", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Status", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Status : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Status);

		}
	}


	[NVP_Manifest(
		Id = "86914E2E-BD45-4CE0-8E50-25FE9D29FB9D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Status", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Status", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Status : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Status = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D8CC02A5-28E7-4069-9D14-147487C3B38B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Shadows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Shadows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Shadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shadows);

		}
	}


	[NVP_Manifest(
		Id = "DE797FA9-83E7-449E-B058-84CB59B08D79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Shadows", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Shadows", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Shadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shadows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C01683DD-F726-470B-A9AB-0A6F604BAD1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.HotSpot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "HotSpot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HotSpot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HotSpot);

		}
	}


	[NVP_Manifest(
		Id = "8032378B-934C-4B6A-8848-61C0F2EFD6A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_HotSpot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_HotSpot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_HotSpot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HotSpot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C926EC04-575A-4BD8-8B4E-31EF031591D0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.FallOff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "FallOff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FallOff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FallOff);

		}
	}


	[NVP_Manifest(
		Id = "2ED28A6E-89DA-42AE-9428-713AC6820854", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_FallOff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_FallOff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_FallOff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FallOff = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BCD24D94-E3F1-4540-8132-BABFA9F97DFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Intensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Intensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Intensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Intensity);

		}
	}


	[NVP_Manifest(
		Id = "8CFE8B62-5D1C-4701-9F65-E9AB620A8926", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Intensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Intensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Intensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Intensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AB6D65C5-6344-46F2-9E84-C8B90108B4BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.LightColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "LightColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LightColor);

		}
	}


	[NVP_Manifest(
		Id = "6A23A4E4-2E1A-450F-8E13-B875D75C0B48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_LightColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_LightColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("ppColor", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LightColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "84E3477D-45BE-4890-84B5-98BB7BF58C37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.PlotGlyph", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "PlotGlyph", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlotGlyph : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotGlyph);

		}
	}


	[NVP_Manifest(
		Id = "FBD6B56F-B575-4F7B-AD23-1D261B19F23B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_PlotGlyph", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_PlotGlyph", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_PlotGlyph : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotGlyph = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6CA45E4C-CC33-4E14-B603-30C55EF34B96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "699E806E-F97D-4A9D-8113-85EBF727A883", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "27E06242-E99C-4A53-AB09-599D600A9B48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		Id = "87A56411-ADAD-4D56-B0AC-F2EAA6DC1C6B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "331B8EA2-AE6C-42DF-BDDA-735D0CD77956", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.AttenuationType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "AttenuationType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AttenuationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AttenuationType);

		}
	}


	[NVP_Manifest(
		Id = "AAD6D88B-E61F-4429-8F1C-F9994F4C21E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_AttenuationType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_AttenuationType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_AttenuationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttenuationType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "54D1E8CE-AA36-43BD-9067-41E3733F70B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.UseLimits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "UseLimits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UseLimits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseLimits);

		}
	}


	[NVP_Manifest(
		Id = "0AA0C112-DD34-41B0-9758-C2B8C69DF093", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_UseLimits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_UseLimits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_UseLimits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseLimits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5FF8CF7E-7D90-4815-95BE-10779F7976CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.StartLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "StartLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class StartLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartLimit);

		}
	}


	[NVP_Manifest(
		Id = "6DC2FC17-2AB5-4045-B4EA-D7900145BD8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_StartLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_StartLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_StartLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C68D21A1-7A83-430F-8033-290E197AFFEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.EndLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "EndLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EndLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndLimit);

		}
	}


	[NVP_Manifest(
		Id = "FF2C15A1-CE6E-43AB-B2D3-8C5DAF2F2EF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_EndLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_EndLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_EndLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "69F35B24-4902-4AF2-A653-9DACC90460B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowType);

		}
	}


	[NVP_Manifest(
		Id = "75038E30-D905-435C-82E0-0B399EC20FFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "06CB1769-CFC9-4206-9BAA-9EC77AA42356", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.MapSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "MapSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MapSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MapSize);

		}
	}


	[NVP_Manifest(
		Id = "C82BCF70-5126-4924-B186-116ADD6D37E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_MapSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_MapSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_MapSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MapSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "06238891-9B4C-4E4A-A837-E951C40BF9A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Softness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Softness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Softness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Softness);

		}
	}


	[NVP_Manifest(
		Id = "1B3DAFF9-FA3C-483C-8D96-2DE0578E9A8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_Softness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_Softness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Set_Softness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Softness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8ABBF6D5-CA1E-4F4B-96B7-24EDB6A9E8D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.FromVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "FromVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FromVector);

		}
	}


	[NVP_Manifest(
		Id = "163FA5EF-2E89-4FBD-B72B-9950B9CA309A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_FromVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_FromVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_FromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FromVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C30AD5B5-0A31-4A64-A8D2-CC9A22302789", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ToVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ToVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ToVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToVector);

		}
	}


	[NVP_Manifest(
		Id = "EB6CE51F-CA2D-42AB-B289-C934E7A60D69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ToVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ToVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ToVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9EFDE1DA-5053-4C0C-A1D4-BFD7270B0C2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.SourceVectorX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "SourceVectorX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceVectorX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceVectorX);

		}
	}


	[NVP_Manifest(
		Id = "E4549609-C337-4665-BD96-C5D5355FB982", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_SourceVectorX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_SourceVectorX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_SourceVectorX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceVectorX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4CF21E8E-E359-43CE-B70C-9A5B5AA22D8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.SourceVectorY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "SourceVectorY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceVectorY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceVectorY);

		}
	}


	[NVP_Manifest(
		Id = "C217D9C4-A0C0-4523-AF60-7B3D8CAD6263", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_SourceVectorY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_SourceVectorY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_SourceVectorY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceVectorY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B7B086B-8FA5-4B57-A8B3-4E3E4F9B616F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.SourceVectorZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "SourceVectorZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceVectorZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceVectorZ);

		}
	}


	[NVP_Manifest(
		Id = "2E627909-409F-4A5F-AEF1-2CCA88E60CC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_SourceVectorZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_SourceVectorZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_SourceVectorZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceVectorZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "51AF4726-F37B-46C2-86A7-010FB56F169A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.LampIntensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "LampIntensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LampIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LampIntensity);

		}
	}


	[NVP_Manifest(
		Id = "4E1EF9AD-CFB2-432F-8AD4-79C461AAF1BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_LampIntensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_LampIntensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LampIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LampIntensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "797C70EC-A6CE-4D7B-AADD-20068AA03040", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ResultIntensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ResultIntensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ResultIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ResultIntensity);

		}
	}


	[NVP_Manifest(
		Id = "54169DDA-A54A-412D-BD34-6703D6FA0951", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ResultIntensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ResultIntensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ResultIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResultIntensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B0FEE25B-58AE-4891-AA96-E79CB447A0D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.LampColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "LampColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LampColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LampColor);

		}
	}


	[NVP_Manifest(
		Id = "2F0B72DF-21D4-4329-9AC5-FDEA6E554D50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_LampColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_LampColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LampColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LampColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "77F43B63-01CB-4B65-A984-18B9415FFBE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ResultColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ResultColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ResultColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ResultColor);

		}
	}


	[NVP_Manifest(
		Id = "F6DBC908-F235-45D8-8ABE-64FDB8204DD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ResultColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ResultColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("ppColor", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ResultColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResultColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9815BFCE-C375-43EE-975A-E33573878D7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.WebFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "WebFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebFile);

		}
	}


	[NVP_Manifest(
		Id = "E3448C8C-1BFD-4E21-A056-E43C574634B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_WebFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_WebFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_WebFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "78292D88-94D5-4E05-8658-C5861CBC7179", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.WebPreview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "WebPreview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebPreview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebPreview);

		}
	}


	[NVP_Manifest(
		Id = "B0E829D6-30A6-4B08-84BB-4C30D49B33D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_WebPreview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_WebPreview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebPreview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebPreview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8F917D84-720B-4797-9780-3B6203E25659", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.WebRotateX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "WebRotateX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebRotateX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebRotateX);

		}
	}


	[NVP_Manifest(
		Id = "CDC75432-BD51-4CFE-89CB-BC1784F53276", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_WebRotateX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_WebRotateX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebRotateX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebRotateX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "17664264-96C9-4517-85AE-7E733A1532B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.WebRotateY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "WebRotateY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebRotateY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebRotateY);

		}
	}


	[NVP_Manifest(
		Id = "B6C3E281-602E-48A8-9FC5-017473CB1E01", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_WebRotateY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_WebRotateY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebRotateY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebRotateY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9CBF2C17-DE70-4F33-93D6-2C4BA7E08FC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.WebRotateZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "WebRotateZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebRotateZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebRotateZ);

		}
	}


	[NVP_Manifest(
		Id = "361114A9-6CB3-4591-B316-0D1B42F03998", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_WebRotateZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_WebRotateZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebRotateZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebRotateZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "28122407-ADC7-4A95-9A10-EB7FF7211E76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.HasTarget", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "HasTarget", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasTarget);

		}
	}


	[NVP_Manifest(
		Id = "BB70B732-8668-400D-A22F-73DA98A4B195", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_HasTarget", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_HasTarget", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_HasTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HasTarget = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FC0C3C0D-7E3A-46D3-856F-ED3506253565", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowSamples", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowSamples", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowSamples : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowSamples);

		}
	}


	[NVP_Manifest(
		Id = "35C8DC61-1ACD-4E05-8C40-8A18C22169C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowSamples", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowSamples", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowSamples : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowSamples = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A7A7EFFC-FBFF-4438-9CD5-6F807B3CADAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowVisible);

		}
	}


	[NVP_Manifest(
		Id = "76A2A48A-C11B-47CD-8D7F-4FA322E0BAD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowVisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowVisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "50C41185-A34A-490A-A446-7FC8813BA12F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowShape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowShape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowShape);

		}
	}


	[NVP_Manifest(
		Id = "53D87586-0143-4B0D-A6C4-6A5089742339", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowShape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowShape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowShape = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A4C9CAFC-AD2B-490A-88C7-9F1A3F2056A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowRadius);

		}
	}


	[NVP_Manifest(
		Id = "D4F41ACE-2FCE-4106-AF95-63ED2CA21E82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowRadius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowRadius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "49AB6191-7264-4DEE-9871-427B69780A5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.IlluminanceDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "IlluminanceDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IlluminanceDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IlluminanceDistance);

		}
	}


	[NVP_Manifest(
		Id = "F8CF3AED-D5ED-493C-8181-3D88180C1E94", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_IlluminanceDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_IlluminanceDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_IlluminanceDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IlluminanceDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5187B19B-2818-438D-86DC-184F536AF5DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowLength);

		}
	}


	[NVP_Manifest(
		Id = "3F10B28E-E014-4A6A-AAEE-E061CA713A07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE51466D-6935-46F9-8167-71B99FA360EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.ShadowWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "ShadowWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowWidth);

		}
	}


	[NVP_Manifest(
		Id = "5EF8EBF9-3CA1-458D-A51C-41962553D832", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_ShadowWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_ShadowWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "06208BC3-38CF-42DD-A492-B36374D8567B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.GlyphDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "GlyphDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GlyphDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GlyphDisplay);

		}
	}


	[NVP_Manifest(
		Id = "4E0F8E00-B405-4EF4-B5CB-EEB498EDD103", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLight.Set_GlyphDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLight", 
		NodeName = "Set_GlyphDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_GlyphDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GlyphDisplay = inputs[1].Value;
			return null;
		}
	}
}
