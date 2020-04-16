using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps; //Google Maps API specific code

namespace Puratos_Domain
{
    public class Location
    {
        //private fields
        private Map _map;
        private List<Pin> _pins;

        //default constructor with option for maptype
        public Location(MapType typeMap)
        {
            _map = new Map();
            _pins = new List<Pin>();
            _map.MapType = typeMap; //type van map
        }

        //default constructor without option for maptype
        public Location()
        {
            _map = new Map();
            _pins = new List<Pin>();
        }

        //set the position of the current map
        public void createPosition(double latitude, double longitude)
        {
            Position pos = new Position(latitude, longitude);
            MapSpan mapSpan = new MapSpan(pos, 0.01, 0.01);
            _map.MoveToRegion(mapSpan);
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

            _map.Pins.Add(pin);
            _pins.Add(pin); //add pin to a list to manage later.

        }

        //return the map obj.
        public Map getMap()
        {
            return _map;
        }

        public void setMap(Map map)
        {
            this._map = map;
        }
    }
}
