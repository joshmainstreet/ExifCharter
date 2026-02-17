using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifCharter.Models
{
        public class Properties
        {
            public string InsertId { get; set; }
            public string LibVersion { get; set; }
            public string MpApiEndpoint { get; set; }
            public DateTime activation_date { get; set; }
            public string actual_flight_time_sec { get; set; }
            public string actual_image_count { get; set; }
            public string browser_family { get; set; }
            public string camera { get; set; }
            public string capturesdk_version { get; set; }
            public string device_family { get; set; }
            public string drone { get; set; }
            public string drone_bridge_name { get; set; }
            public string drone_bridge_version { get; set; }
            public string drone_library_name { get; set; }
            public string drone_library_version { get; set; }
            public string expected_flight_time_sec { get; set; }
            public string expected_image_count { get; set; }
            public bool is_bot { get; set; }
            public bool is_mobile { get; set; }
            public bool is_pc { get; set; }
            public bool is_tablet { get; set; }
            public bool is_touch_capable { get; set; }
            public string license2_TOS { get; set; }
            public DateTime license2_creation_date { get; set; }
            public string license2_edition { get; set; }
            public bool license2_paid { get; set; }
            public string license2_product_code { get; set; }
            public string license2_valid_support { get; set; }
            public string license_event { get; set; }
            public string mission_type { get; set; }
            public string mp_lib { get; set; }
            public object mp_processing_time_ms { get; set; }
            public string os_family { get; set; }
            public string platform { get; set; }
            public string project_datetime { get; set; }
            public string project_datetime1 { get; set; }
            public string project_geotag_alt { get; set; }
            public string setting_column_count { get; set; }
            public string setting_column_front_overlap { get; set; }
            public string setting_exposure_compensation { get; set; }
            public string setting_flight_shape_max_deviation { get; set; }
            public string setting_max_altitude { get; set; }
            public string setting_min_altitude { get; set; }
            public string setting_min_picture_count_per_column { get; set; }
            public string setting_mission_finish_action { get; set; }
            public string setting_photo_trigger_type { get; set; }
            public string setting_poi_max_altitude { get; set; }
            public string setting_poi_min_altitude { get; set; }
            public string setting_speed_percent { get; set; }
            public string setting_staging_altitude { get; set; }
            public string setting_white_balance_mode { get; set; }
            public string state { get; set; }
            public string surveyregion_type { get; set; }
            public string version_name { get; set; }
            public string country { get; set; }
            public string device_model { get; set; }
            public string language { get; set; }
            public string license2_partner { get; set; }
            public string license2_partner_name { get; set; }
            public string offline { get; set; }
            public string operating_system_language { get; set; }
            public string operating_system_version { get; set; }
            public string scan_mission_type { get; set; }
            public string screen_height { get; set; }
            public string screen_width { get; set; }
            public string screen_xdpi { get; set; }
            public string screen_ydpi { get; set; }
            public string setting_altitude { get; set; }
            public string setting_angle_between_photos { get; set; }
            public string setting_mission_critical_battery { get; set; }
            public string setting_poi_altitude { get; set; }
            public DateTime? timestamp { get; set; }
            public string units { get; set; }
            public string setting_column_bearing { get; set; }
            public string setting_picture_count_per_column { get; set; }
            public string setting_staging_speed { get; set; }
            public string surveyregion_circle_radius { get; set; }
            public string surveyregion_rectangle_height { get; set; }
            public string surveyregion_rectangle_rotation { get; set; }
            public string surveyregion_rectangle_width { get; set; }
            public string license2_key { get; set; }
            public string project_geotag_latitude { get; set; }
            public string project_geotag_longitude { get; set; }
            public string surveyregion_center_latitude { get; set; }
            public string surveyregion_center_longitude { get; set; }
            public string surveyregion_outline { get; set; }
            public string surveyregion_outline_vertex_count { get; set; }
            public string surveyregion_rectangle_center_latitude { get; set; }
            public string surveyregion_rectangle_center_longitude { get; set; }
            public string setting_camera_heading_type { get; set; }
            public string setting_camera_pitch { get; set; }
            public string setting_capture_lines_crosshatch_count { get; set; }
            public string setting_capture_lines_direction { get; set; }
            public string setting_front_overlap { get; set; }
            public string setting_side_overlap { get; set; }
        }
        public class Root
        {
            public string name { get; set; }
            public string distinct_id { get; set; }
            public List<object> labels { get; set; }
            public object time { get; set; }
            public int sampling_factor { get; set; }
            public string dataset { get; set; }
            public Properties properties { get; set; }
        }
}
