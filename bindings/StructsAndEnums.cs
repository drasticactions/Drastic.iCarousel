using ObjCRuntime;

namespace Drastic.iCarousel
{
	[Native]
	public enum iCarouselType : long
	{
		Linear = 0,
		Rotary,
		InvertedRotary,
		Cylinder,
		InvertedCylinder,
		Wheel,
		InvertedWheel,
		CoverFlow,
		CoverFlow2,
		TimeMachine,
		InvertedTimeMachine,
		Custom
	}

	[Native]
	public enum iCarouselOption : long
	{
		Wrap = 0,
		ShowBackfaces,
		OffsetMultiplier,
		VisibleItems,
		Count,
		Arc,
		Angle,
		Radius,
		Tilt,
		Spacing,
		FadeMin,
		FadeMax,
		FadeRange,
		FadeMinAlpha
	}
}
