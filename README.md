[![NuGet Version](https://img.shields.io/nuget/v/Drastic.iCarousel.svg)](https://www.nuget.org/packages/Drastic.iCarousel/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.iCarousel

Drastic.iCarousel is a binding of iCarousel.

>iCarousel is a class designed to simplify the implementation of various types of carousel (paged, scrolling views) on iPhone, iPad and Mac OS. iCarousel implements a number of common effects such as cylindrical, flat and "CoverFlow" style carousels, as well as providing hooks to implement your own bespoke effects. Unlike many other "CoverFlow" libraries, iCarousel can work with any kind of view, not just images, so it is ideal for presenting paged data in a fluid and impressive way in your app. It also makes it extremely easy to swap between different carousel effects with minimal code changes.

## How To Use

You need to set up at least two items: iCarousel and iCarouselDataSource

```c#
public class DrasticCarousel : iCarousel
        {
            public override nint NumberOfItems => 10;

            public DrasticCarousel()
            {
                this.DataSource = new DrasticCarouselDataSource();
            }
        }

        public class DrasticCarouselDataSource : iCarouselDataSource
        {
            private Random random;
            public DrasticCarouselDataSource()
            {
                this.random = new Random();
            }
            [Export("numberOfItemsInCarousel:")]
            public nint NumberOfItemsInCarousel(iCarousel carousel)
            {
                return 10;
            }

            public override UIView CarouselWithView(iCarousel carousel, nint index, UIView? view)
            {
                if (view is null)
                {
                    view = new UIImageView(new CGRect(0, 0, 500, 500));
                }

                if (view is UIImageView imageView)
                {
                    // Load something into image view.
                }

                return view;
            }
        }
```

The inner carousel items are `UI/NSView`s and can be anything you like, not just images.