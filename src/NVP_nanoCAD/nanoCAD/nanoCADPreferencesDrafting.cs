using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies drafting settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesDrafting 
{

	[NVP_Manifest(
		Id = "E3DE876A-FEC2-4019-A1E8-7DF20D7A2291", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.nanoCADPreferencesDrafting_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "_nanoCADPreferencesDrafting_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesDrafting_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesDrafting _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesDrafting;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9461281E-81EB-4129-A6A9-7C4DD33CFBF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.nanoCADPreferencesDrafting_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "_nanoCADPreferencesDrafting_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesDrafting_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesDrafting _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesDrafting;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A023C61A-481B-427C-8EEE-CB6C6F63F845", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "6BCC1914-0DE5-4798-80AE-5A10ADE36E32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapMarker", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapMarker", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the snap marker displays for snap locations.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the snap marker displays for snap locations.
	///</summary>
	public class Set_AutoSnapMarker : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMarker = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5AEC994A-E21F-4FCF-9F3F-A4C3C72D67DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapMarker", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapMarker", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the snap marker displays for snap locations.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether the snap marker displays for snap locations.
	///</summary>
	public class AutoSnapMarker : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMarker);

		}
	}


	[NVP_Manifest(
		Id = "7A31DBF2-8AFC-414A-8830-9E3B794FF44A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapMagnet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapMagnet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the snap magnet is turned on.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the snap magnet is turned on.
	///</summary>
	public class Set_AutoSnapMagnet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMagnet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E8230299-E896-436D-B9F6-52E02DD2B468", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapMagnet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapMagnet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the snap magnet is turned on.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether the snap magnet is turned on.
	///</summary>
	public class AutoSnapMagnet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMagnet);

		}
	}


	[NVP_Manifest(
		Id = "C4864EA0-FA8A-485F-9ED5-CF3946944BD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapTooltip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapTooltip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether snap tooltips are turned on.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether snap tooltips are turned on.
	///</summary>
	public class Set_AutoSnapTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapTooltip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "86D00364-7DD9-440C-B3D7-698B72FB2CCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapTooltip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapTooltip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether snap tooltips are turned on.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether snap tooltips are turned on.
	///</summary>
	public class AutoSnapTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapTooltip);

		}
	}


	[NVP_Manifest(
		Id = "5715A463-EF95-446B-9353-3C936A55FED3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapAperture", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapAperture", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the aperture cursor displays.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the aperture cursor displays.
	///</summary>
	public class Set_AutoSnapAperture : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapAperture = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2CA63411-DB7D-4E2F-95BF-C39E820E2850", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapAperture", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapAperture", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the aperture cursor displays.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether the aperture cursor displays.
	///</summary>
	public class AutoSnapAperture : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapAperture);

		}
	}


	[NVP_Manifest(
		Id = "9048ADF7-F4AF-4725-B8DC-6074C95300F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapApertureSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapApertureSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the aperture cursor size.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the aperture cursor size.
	///</summary>
	public class Set_AutoSnapApertureSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapApertureSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A4C0A183-713C-4DC2-BAB6-F9D2FD7B7188", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapApertureSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapApertureSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the aperture cursor size.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns the aperture cursor size.
	///</summary>
	public class AutoSnapApertureSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapApertureSize);

		}
	}


	[NVP_Manifest(
		Id = "E2AFAD90-8DDA-4E9D-AA35-D417E93AA54C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapMarkerColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapMarkerColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap marker color.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the snap marker color.
	///</summary>
	public class Set_AutoSnapMarkerColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMarkerColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25B056B8-2621-4BF6-83BD-6900F33FDAF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapMarkerColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapMarkerColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap marker color.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns the snap marker color.
	///</summary>
	public class AutoSnapMarkerColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMarkerColor);

		}
	}


	[NVP_Manifest(
		Id = "21BE2B71-22FE-46B3-84CB-AD29B9073A23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoSnapMarkerSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoSnapMarkerSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap marker size in pixels.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns the snap marker size in pixels.
	///</summary>
	public class Set_AutoSnapMarkerSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMarkerSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3300CEED-32A2-4B70-B865-90A48FE4F78F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoSnapMarkerSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoSnapMarkerSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the snap marker size in pixels.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns the snap marker size in pixels.
	///</summary>
	public class AutoSnapMarkerSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMarkerSize);

		}
	}


	[NVP_Manifest(
		Id = "E75FE248-6681-4AFB-AE69-921207B18F15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_PolarTrackingVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_PolarTrackingVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether polar tracking is turned on.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether polar tracking is turned on.
	///</summary>
	public class Set_PolarTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PolarTrackingVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A188D4EF-E0ED-47C0-BB9F-938686F019F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.PolarTrackingVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "PolarTrackingVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether polar tracking is turned on.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether polar tracking is turned on.
	///</summary>
	public class PolarTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PolarTrackingVector);

		}
	}


	[NVP_Manifest(
		Id = "EBD37F4D-0D04-4FD0-B42E-C576DAEB3BFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_FullScreenTrackingVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_FullScreenTrackingVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether full-screen tracking is turned on.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether full-screen tracking is turned on.
	///</summary>
	public class Set_FullScreenTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FullScreenTrackingVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "508CFDFE-F2D8-499C-8B56-D9B7B79AF2DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.FullScreenTrackingVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "FullScreenTrackingVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether full-screen tracking is turned on.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether full-screen tracking is turned on.
	///</summary>
	public class FullScreenTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullScreenTrackingVector);

		}
	}


	[NVP_Manifest(
		Id = "93CD0B3C-B86E-4910-8D76-7919028930DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AutoTrackTooltip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AutoTrackTooltip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether AutoTrack tooltips are turned on.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether AutoTrack tooltips are turned on.
	///</summary>
	public class Set_AutoTrackTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoTrackTooltip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B567AF36-EAE1-486F-A632-D7479B9E3F2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AutoTrackTooltip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AutoTrackTooltip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether AutoTrack tooltips are turned on.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns whether AutoTrack tooltips are turned on.
	///</summary>
	public class AutoTrackTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoTrackTooltip);

		}
	}


	[NVP_Manifest(
		Id = "0C1749E4-2A6A-4201-81C6-E4AD7500E153", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.Set_AlignmentPointAcquisition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "Set_AlignmentPointAcquisition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how AutoAlignment points are obtained.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("nanoCAD.AcAlignmentPointAcquisition", typeof(System.Object))]

	///<summary>
	///Specifies or returns how AutoAlignment points are obtained.
	///</summary>
	public class Set_AlignmentPointAcquisition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AlignmentPointAcquisition = ((nanoCAD.AcAlignmentPointAcquisition)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "053CA5E6-3738-46EB-B232-C5C2142195B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesDrafting.AlignmentPointAcquisition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesDrafting", 
		NodeName = "AlignmentPointAcquisition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how AutoAlignment points are obtained.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]

	///<summary>
	///Specifies or returns how AutoAlignment points are obtained.
	///</summary>
	public class AlignmentPointAcquisition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AlignmentPointAcquisition);

		}
	}
}
