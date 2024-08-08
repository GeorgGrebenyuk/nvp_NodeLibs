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
