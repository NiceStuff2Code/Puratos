using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps; //Google Maps API specific code

namespace Puratos_Domain
{
    class Location
    {
        //private fields
        private Map map;
        private List<Pin> pins;

        //default constructor with option for maptype
        public Location(MapType typeMap)
        {
            map = new Map();
            pins = new List<Pin>();
            map.MapType = typeMap; //type van map
        }

        //default constructor without option for maptype
        public Location()
        {
            map = new Map();
            pins = new List<Pin>();
        }

        //set the position of the current map
        public void createPosition(double latitude, double longitude)
        {
            Position pos = new Position(latitude, longitude);
            MapSpan mapSpan = new MapSpan(pos, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

        //create a pin, can call multiple times for multiple location to pin.
        public void createPin(string label, string adress, Position pos) {
            Pin pin = new Pin();
            try
            {
                pin.Label = label;
            }catch(ArgumentException e )
            {
                string message = e.Message;
                throw new ArgumentException("Location class, Business layer ERROR: %s", message);

            }

            pin.Address = adress;
            pin.Type = PinType.Place;
            pin.Position = pos;

            map.Pins.Add(pin);
            pins.Add(pin); //add pin to a list to manage later.

        }

        //return the map obj.
        public Map getMap()
        {
            return map;
        }
    }
}
