using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coaster.Tracks
{
    public static class TrackSegmentMapGenerator // https://github.com/kevinburke/rct/blob/master/tracks/segment.go
    {
        // TODO: Much better way
        // Load from XML? (Serialize this)
        public static Dictionary<SegmentType, TrackSegment> GenerateSegmentMap()
        {
            Dictionary<SegmentType, TrackSegment> TrackSegmentMap = new Dictionary<SegmentType, TrackSegment>();

	        TrackSegmentMap[SegmentType.ELEM_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x0,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_END_STATION] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BEGIN_STATION] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_MIDDLE_STATION] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_TO_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_TO_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xe,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0xf,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_5_TILES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x10,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_5_TILES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x11,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x12,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x13,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BANK_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x14,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BANK_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x15,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BANKED_LEFT_QUARTER_TURN_5_TILES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x16,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BANKED_RIGHT_QUARTER_TURN_5_TILES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x17,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BANK_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x18,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BANK_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x19,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1a,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1b,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BANK_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BANK_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1e,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x1f,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x20,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x21,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_5_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x22,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_5_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x23,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_5_TILES_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x24,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_5_TILES_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x25,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_S_BEND_LEFT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x26,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_S_BEND_RIGHT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x27,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_VERTICAL_LOOP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x28,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_VERTICAL_LOOP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x29,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_3_TILES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_3_TILES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2b,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_3_TILES_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_3_TILES_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_3_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2e,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_3_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x2f,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_3_TILES_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x30,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_3_TILES_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x31,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_1_TILE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x32,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_1_TILE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x33,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_TWIST_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x34,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_TWIST_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x35,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_TWIST_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x36,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 30,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_TWIST_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x37,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 30,
	        };
	        TrackSegmentMap[SegmentType.ELEM_HALF_LOOP_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x38,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 19,
	        };
	        TrackSegmentMap[SegmentType.ELEM_HALF_LOOP_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x39,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 13,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_CORKSCREW_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 10,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_CORKSCREW_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3b,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 10,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_CORKSCREW_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 22,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_CORKSCREW_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 22,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3e,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x3f,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x40,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x41,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_TOWER_BASE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x42,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_UP_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 12,
	        };
	        TrackSegmentMap[SegmentType.ELEM_TOWER_SECTION] = new TrackSegment()
	        {
		        Type = (SegmentType)0x43,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_UP_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x44,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x45,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x46,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_25_DEG_UP_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x47,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_TO_60_DEG_UP_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x48,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP_TO_25_DEG_UP_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x49,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_TO_FLAT_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4a,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4b,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4c,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_25_DEG_DOWN_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_TO_60_DEG_DOWN_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4e,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN_TO_25_DEG_DOWN_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x4f,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_TO_FLAT_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x50,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_5_TILES_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x51,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_5_TILES_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x52,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_S_BEND_LEFT_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x53,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_S_BEND_RIGHT_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x54,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_3_TILES_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x55,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_3_TILES_COVERED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x56,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_HALF_BANKED_HELIX_UP_SMALL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x57,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 4,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_HALF_BANKED_HELIX_UP_SMALL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x58,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = -4,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_HALF_BANKED_HELIX_DOWN_SMALL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x59,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 4,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_HALF_BANKED_HELIX_DOWN_SMALL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = -4,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_HALF_BANKED_HELIX_UP_LARGE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5b,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = -4,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_HALF_BANKED_HELIX_UP_LARGE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 4,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_HALF_BANKED_HELIX_DOWN_LARGE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = -4,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_HALF_BANKED_HELIX_DOWN_LARGE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5e,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 4,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_1_TILE_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x5f,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 0,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_1_TILE_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x60,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_1_TILE_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x61,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 0,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_1_TILE_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x62,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BRAKES] = new TrackSegment()
	        {
		        Type = (SegmentType)0x63,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_ROTATION_CONTROL_TOGGLE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x64,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_INVERTED_90_DEG_UP_TO_FLAT_QUARTER_LOOP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x65,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_BANKED_HELIX_LARGE_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x66,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_BANKED_HELIX_LARGE_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x67,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_BANKED_HELIX_LARGE_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x68,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_BANKED_HELIX_LARGE_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x69,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_HELIX_LARGE_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_HELIX_LARGE_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6b,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_HELIX_LARGE_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 3,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_HELIX_LARGE_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_LEFT_BANKED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6e,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_UP_RIGHT_BANKED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x6f,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_WATERFALL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x70,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RAPIDS] = new TrackSegment()
	        {
		        Type = (SegmentType)0x71,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_ON_RIDE_PHOTO] = new TrackSegment()
	        {
		        Type = (SegmentType)0x72,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_LEFT_BANKED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x73,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_25_DEG_DOWN_RIGHT_BANKED] = new TrackSegment()
	        {
		        Type = (SegmentType)0x74,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_WATER_SPLASH] = new TrackSegment()
	        {
		        Type = (SegmentType)0x75,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 5,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_60_DEG_UP_LONG_BASE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x76,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 11,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP_TO_FLAT_LONG_BASE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x77,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 11,
	        };
	        TrackSegmentMap[SegmentType.ELEM_WHIRLPOOL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x78,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN_TO_FLAT_LONG_BASE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x79,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -11,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLAT_TO_60_DEG_DOWN_LONG_BASE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -11,
	        };
	        TrackSegmentMap[SegmentType.ELEM_CABLE_LIFT_HILL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7b,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 20,
	        };
	        TrackSegmentMap[SegmentType.ELEM_REVERSE_WHOA_BELLY_SLOPE] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 6,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 30,
	        };
	        TrackSegmentMap[SegmentType.ELEM_REVERSE_WHOA_BELLY_VERTICAL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7d,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_UP_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 10,
	        };
	        TrackSegmentMap[SegmentType.ELEM_90_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7e,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_UP_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_90_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x7f,
		        InputDegree = Degree.TRACK_DOWN_90,
		        OutputDegree = Degree.TRACK_DOWN_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_UP_TO_90_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x80,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 7,
	        };
	        TrackSegmentMap[SegmentType.ELEM_90_DEG_DOWN_TO_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x81,
		        InputDegree = Degree.TRACK_DOWN_90,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -7,
	        };
	        TrackSegmentMap[SegmentType.ELEM_90_DEG_UP_TO_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x82,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 7,
	        };
	        TrackSegmentMap[SegmentType.ELEM_60_DEG_DOWN_TO_90_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x83,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -7,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BRAKE_FOR_DROP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x84,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_EIGHTH_TO_DIAG] = new TrackSegment()
	        {
		        Type = (SegmentType)0x85,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_EIGHTH_TO_DIAG] = new TrackSegment()
	        {
		        Type = (SegmentType)0x86,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_EIGHTH_TO_ORTHOGONAL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x87,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_EIGHTH_TO_ORTHOGONAL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x88,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_EIGHTH_BANK_TO_DIAG] = new TrackSegment()
	        {
		        Type = (SegmentType)0x89,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_EIGHTH_BANK_TO_DIAG] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_EIGHTH_BANK_TO_ORTHOGONAL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8b,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_EIGHTH_BANK_TO_ORTHOGONAL] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -3,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8d,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8e,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x8f,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x90,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_UP_TO_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x91,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_60_DEG_UP_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x92,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_UP_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x93,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x94,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x95,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -8,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x96,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_DOWN_TO_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x97,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_60_DEG_DOWN_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x98,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_DOWN_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x99,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT_TO_60_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9a,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_60_DEG_UP_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9b,
		        InputDegree = Degree.TRACK_UP_60,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT_TO_60_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9c,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_60,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_60_DEG_DOWN_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9d,
		        InputDegree = Degree.TRACK_DOWN_60,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9e,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_FLAT_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0x9f,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_LEFT_BANK_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa0,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_RIGHT_BANK_TO_FLAT] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa1,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_LEFT_BANK_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa2,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_RIGHT_BANK_TO_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa3,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_UP_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa4,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_UP_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa5,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_LEFT_BANK_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa6,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_RIGHT_BANK_TO_25_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa7,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_DOWN_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa8,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_25_DEG_DOWN_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xa9,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -1,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xaa,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_DIAG_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xab,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LOG_FLUME_REVERSER] = new TrackSegment()
	        {
		        Type = (SegmentType)0xac,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_SPINNING_TUNNEL] = new TrackSegment()
	        {
		        Type = (SegmentType)0xad,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BARREL_ROLL_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xae,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BARREL_ROLL_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xaf,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BARREL_ROLL_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb0,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 28,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BARREL_ROLL_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb1,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 28,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_BANK_TO_LEFT_QUARTER_TURN_3_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb2,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_BANK_TO_RIGHT_QUARTER_TURN_3_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb3,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_QUARTER_TURN_3_TILES_25_DEG_DOWN_TO_LEFT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb4,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_QUARTER_TURN_3_TILES_25_DEG_DOWN_TO_RIGHT_BANK] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb5,
		        InputDegree = Degree.TRACK_DOWN_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = -3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_POWERED_LIFT] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb6,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_LARGE_HALF_LOOP_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb7,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 2,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_LARGE_HALF_LOOP_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb8,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = -2,
		        ElevationDelta = 3,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_LARGE_HALF_LOOP_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xb9,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = -1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 2,
		        ElevationDelta = 29,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_LARGE_HALF_LOOP_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xba,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = -1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = -2,
		        ElevationDelta = 29,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_FLYER_TWIST_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xbb,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 30,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_FLYER_TWIST_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xbc,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 30,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_FLYER_TWIST_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xbd,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_FLYER_TWIST_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xbe,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLYER_HALF_LOOP_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xbf,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 15,
	        };
	        TrackSegmentMap[SegmentType.ELEM_FLYER_HALF_LOOP_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc0,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_25,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 17,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_FLY_CORKSCREW_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc1,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 6,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_FLY_CORKSCREW_UP_TO_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc2,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 6,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_FLY_CORKSCREW_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc3,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 26,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_FLY_CORKSCREW_DOWN_TO_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc4,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 26,
	        };
	        TrackSegmentMap[SegmentType.ELEM_HEARTLINE_TRANSFER_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc5,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_HEARTLINE_TRANSFER_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc6,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 28,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_HEARTLINE_ROLL] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc7,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 6,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_HEARTLINE_ROLL] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc8,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 6,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_MINI_GOLF_HOLE_A] = new TrackSegment()
	        {
		        Type = (SegmentType)0xc9,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_MINI_GOLF_HOLE_B] = new TrackSegment()
	        {
		        Type = (SegmentType)0xca,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_MINI_GOLF_HOLE_C] = new TrackSegment()
	        {
		        Type = (SegmentType)0xcb,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_MINI_GOLF_HOLE_D] = new TrackSegment()
	        {
		        Type = (SegmentType)0xcc,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_MINI_GOLF_HOLE_E] = new TrackSegment()
	        {
		        Type = (SegmentType)0xcd,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_INVERTED_FLAT_TO_90_DEG_DOWN_QUARTER_LOOP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xce,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 20,
	        };
	        TrackSegmentMap[SegmentType.ELEM_90_DEG_UP_QUARTER_LOOP_TO_INVERTED] = new TrackSegment()
	        {
		        Type = (SegmentType)0xcf,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        ForwardDelta = -1,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 16,
	        };
	        TrackSegmentMap[SegmentType.ELEM_QUARTER_LOOP_INVERT_TO_90_DEG_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd0,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_DOWN_90,
		        StartingBank = Bank.TRACK_BANK_UPSIDE_DOWN,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 4,
		        //DirectionDelta: DIR_180_DEG,
		        SidewaysDelta = 0,
		        ElevationDelta = 16,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_CURVED_LIFT_HILL] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd1,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_CURVED_LIFT_HILL] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd2,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 2,
	        };
	        TrackSegmentMap[SegmentType.ELEM_LEFT_REVERSER] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd3,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_RIGHT_REVERSER] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd4,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 3,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_AIR_THRUST_TOP_CAP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd5,
		        InputDegree = Degree.TRACK_UP_90,
		        OutputDegree = Degree.TRACK_DOWN_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_AIR_THRUST_VERTICAL_DOWN] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd6,
		        InputDegree = Degree.TRACK_DOWN_90,
		        OutputDegree = Degree.TRACK_DOWN_90,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 0,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -10,
	        };
	        TrackSegmentMap[SegmentType.ELEM_AIR_THRUST_VERTICAL_DOWN_TO_LEVEL] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd7,
		        InputDegree = Degree.TRACK_DOWN_90,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 6,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = -30,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BLOCK_BRAKES] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd8,
		        InputDegree = Degree.TRACK_NONE,
		        OutputDegree = Degree.TRACK_NONE,
		        StartingBank = Bank.TRACK_BANK_NONE,
		        EndingBank = Bank.TRACK_BANK_NONE,
		        ForwardDelta = 1,
		        //DirectionDelta: DIR_STRAIGHT,
		        SidewaysDelta = 0,
		        ElevationDelta = 0,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BANKED_LEFT_QUARTER_TURN_3_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xd9,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_LEFT,
		        EndingBank = Bank.TRACK_BANK_LEFT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_LEFT,
		        SidewaysDelta = 2,
		        ElevationDelta = 4,
	        };
	        TrackSegmentMap[SegmentType.ELEM_BANKED_RIGHT_QUARTER_TURN_3_TILES_25_DEG_UP] = new TrackSegment()
	        {
		        Type = (SegmentType)0xda,
		        InputDegree = Degree.TRACK_UP_25,
		        OutputDegree = Degree.TRACK_UP_25,
		        StartingBank = Bank.TRACK_BANK_RIGHT,
		        EndingBank = Bank.TRACK_BANK_RIGHT,
		        ForwardDelta = 2,
		        //DirectionDelta: DIR_90_DEG_RIGHT,
		        SidewaysDelta = -2,
		        ElevationDelta = 4,
	        };

	        TrackSegmentMap[SegmentType.ELEM_END_OF_RIDE] = new TrackSegment()
	        {
		        Type = (SegmentType)0xff,
	        };

            return TrackSegmentMap;
        }
    }
}
