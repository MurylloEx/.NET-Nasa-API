using System;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Nasa
{

    #region "NASA Astronomic Picture of Day"

    public struct NASA_APOD_DATA
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("explanation")]
        public string Explanation { get; set; }

        [JsonProperty("hdurl")]
        public string HighQualityUrl { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    #endregion

    #region "NASA Mars Rover Photos"

    public struct NASA_MARS_CAMERA_INFO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public struct NASA_MARS_ROVER_INFO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("landing_date")]
        public DateTime? LandingDate { get; set; }

        [JsonProperty("launch_date")]
        public DateTime? LaunchDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("max_sol")]
        public int MaxSol { get; set; }

        [JsonProperty("max_date")]
        public DateTime? MaxDate { get; set; }

        [JsonProperty("total_photos")]
        public int TotalPhotos { get; set; }

        [JsonProperty("cameras")]
        public NASA_MARS_CAMERA_INFO[] Cameras { get; set; }
    }

    public struct NASA_MARS_CAMERA
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rover_id")]
        public int RoverId { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public struct NASA_MARS_PHOTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sol")]
        public int Sol { get; set; }

        [JsonProperty("camera")]
        public NASA_MARS_CAMERA? Camera { get; set; }

        [JsonProperty("img_src")]
        public string ImageSource { get; set; }

        [JsonProperty("earth_date")]
        public DateTime? EarthDate { get; set; }

        [JsonProperty("rover")]
        public NASA_MARS_ROVER_INFO? RoverInfo { get; set; }
    }

    public struct NASA_MARS_DATA
    {
        [JsonProperty("photos")]
        public NASA_MARS_PHOTO[] Photos;
    }

    #endregion

    #region "NASA Gene Laboratory"

    public struct NASA_GENELAB_SHARDS
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("successful")]
        public int Successful { get; set; }

        [JsonProperty("skipped")]
        public int Skipped { get; set; }

        [JsonProperty("failed")]
        public int Failed { get; set; }
    }

    public struct NASA_GENELAB_STUDY_PERSON
    {
        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Middle Initials")]
        public string AuthoritySourceURL { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }
    }

    public struct NASA_GENELAB_STUDY_MISSION
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("End Date")]
        public string EndDate { get; set; }

        [JsonProperty("Start Date")]
        public string StartDate { get; set; }
    }

    public struct NASA_GENELAB_SOURCE
    {
        [JsonProperty("Authoritative Source URL")]
        public string AuthoritySourceURL { get; set; }

        [JsonProperty("Flight Program")]
        public string FlightProgram { get; set; }

        [JsonProperty("Material Type")]
        public string MaterialType { get; set; }

        [JsonProperty("Project Identifier")]
        public string ProjectIdentifier { get; set; }

        [JsonProperty("Accession")]
        public string Accession { get; set; }

        [JsonProperty("Project Link")]
        public string ProjectLink { get; set; }

        [JsonProperty("Study Identifier")]
        public string StudyIdentifier { get; set; }

        [JsonProperty("Study Protocol Name")]
        public string StudyProtocolName { get; set; }

        [JsonProperty("Study Assay Technology Type")]
        public string StudyAssayTechnologyType { get; set; }

        [JsonProperty("Acknowledgments")]
        public string Acknowledgments { get; set; }

        [JsonProperty("Study Assay Technology Platform")]
        public string StudyAssayTechnologyPlatform { get; set; }

        [JsonProperty("Study Person")]
        public NASA_GENELAB_STUDY_PERSON? StudyPerson { get; set; }

        [JsonProperty("Study Protocol Type")]
        public string StudyProtocolType { get; set; }

        [JsonProperty("Study Title")]
        public string StudyTitle { get; set; }

        [JsonProperty("Study Factor Type")]
        public string StudyFactorType { get; set; }

        [JsonProperty("Study Public Release Date")]
        public string StudyPublicReleaseDate { get; set; }

        [JsonProperty("Parameter Value")]
        public string ParameterValue { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("Study Factor Name")]
        public string StudyFactorName { get; set; }

        [JsonProperty("Study Assay Measurement Type")]
        public string StudyAssayMeasurementType { get; set; }

        [JsonProperty("Project Type")]
        public string ProjectType { get; set; }

        [JsonProperty("Factor Value")]
        public string FactorValue { get; set; }

        [JsonProperty("Data Source Accession")]
        public string DataSourceAccession { get; set; }

        [JsonProperty("Data Source Type")]
        public string DataSourceType { get; set; }

        [JsonProperty("Project Title")]
        public string ProjectTitle { get; set; }

        [JsonProperty("Study Funding Agency")]
        public string StudyFundingAgency { get; set; }

        [JsonProperty("Study Protocol Description")]
        public string StudyProtocolDescription { get; set; }

        [JsonProperty("Experiment Platform")]
        public string ExperimentPlatform { get; set; }

        [JsonProperty("Characteristics")]
        public string Characteristics { get; set; }

        [JsonProperty("Study Grant Number")]
        public string StudyGrantNumber { get; set; }

        [JsonProperty("Study Publication Author List")]
        public string StudyPublicationAuthorList { get; set; }

        [JsonProperty("Mission")]
        public NASA_GENELAB_STUDY_MISSION? Mission { get; set; }

        [JsonProperty("Study Publication Title")]
        public string StudyPublicationTitle { get; set; }

        [JsonProperty("Managing NASA Center")]
        public string ManagingNASACenter { get; set; }

        [JsonProperty("Study Description")]
        public string StudyDescription { get; set; }

        [JsonProperty("organism")]
        public string Organism { get; set; }
    }

    public struct NASA_GENELAB_HIGHLIGHT
    {
        [JsonProperty("all")]
        public string[] All { get; set; }
    }

    public struct NASA_GENELAB_HIT_INFO
    {
        [JsonProperty("_index")]
        public string Index { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_score")]
        public double Score { get; set; }

        [JsonProperty("_source")]
        public NASA_GENELAB_SOURCE? Source { get; set; }

        [JsonProperty("highlight")]
        public NASA_GENELAB_HIGHLIGHT? Highlight { get; set; }
    }

    public struct NASA_GENELAB_HITS
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("hits")]
        public NASA_GENELAB_HIT_INFO[] Hits { get; set; }

    }

    public struct NASA_GENELAB_DATA
    {
        [JsonProperty("took")]
        public int Took { get; set; }

        [JsonProperty("timed_out")]
        public bool TimedOut { get; set; }

        [JsonProperty("_shards")]
        public NASA_GENELAB_SHARDS? Shards { get; set; }

        [JsonProperty("hits")]
        public NASA_GENELAB_HITS? Hits { get; set; }
    }

    #endregion

    #region "NASA Earth Polychromatic Imaging Camera"

    public struct NASA_EPIC_DATE_STRUCTURE
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }
    }
    
    public struct NASA_EPIC_QUATERNIONS
    {
        [JsonProperty("q0")]
        public double Q0 { get; set; }

        [JsonProperty("q1")]
        public double Q1 { get; set; }

        [JsonProperty("q2")]
        public double Q2 { get; set; }

        [JsonProperty("q3")]
        public double Q3 { get; set; }
    }

    public struct NASA_EPIC_3D_POINT
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }
    }

    public struct NASA_EPIC_COORDINATES
    {
        [JsonProperty("centroid_coordinates")]
        public NASA_EPIC_3D_POINT? CentroIdCoordinates { get; set; }

        [JsonProperty("dscovr_j2000_position")]
        public NASA_EPIC_3D_POINT? Dscovr_J2000_Position { get; set; }

        [JsonProperty("lunar_j2000_position")]
        public NASA_EPIC_3D_POINT? Lunar_J2000_Position { get; set; }

        [JsonProperty("sun_j2000_position")]
        public NASA_EPIC_3D_POINT? Sun_J2000_Position { get; set; }

        [JsonProperty("attitude_quaternions")]
        public NASA_EPIC_QUATERNIONS? AttitudeQuaternions { get; set; }
    }

    public struct NASA_EPIC_GEOGRAPHICAL_COORDINATES
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }

    public struct NASA_EPIC_DATA
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("centroid_coordinates")]
        public NASA_EPIC_GEOGRAPHICAL_COORDINATES CentroIdCoordinates { get; set; }

        [JsonProperty("dscovr_j2000_position")]
        public NASA_EPIC_3D_POINT Dscovr_J2000_Position { get; set; }

        [JsonProperty("lunar_j2000_position")]
        public NASA_EPIC_3D_POINT Lunar_J2000_Position { get; set; }

        [JsonProperty("sun_j2000_position")]
        public NASA_EPIC_3D_POINT Sun_J2000_Position { get; set; }

        [JsonProperty("attitude_quaternions")]
        public NASA_EPIC_QUATERNIONS AttitudeQuaternions { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("coords")]
        public NASA_EPIC_COORDINATES Coordinates { get; set; }
    }

    #endregion

    #region "NASA Earth Landset-8"

    public struct NASA_EARTH_ASSETS_RESULT
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public struct NASA_EARTH_RESOURCE
    {
        [JsonProperty("dataset")]
        public string Dataset { get; set; }

        [JsonProperty("planet")]
        public string Planet { get; set; }
    }

    public struct NASA_EARTH_DATA
    {
        [JsonProperty("cloud_score")]
        public double CloudScore { get; set; }

        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public NASA_EARTH_RESOURCE? Resource { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public struct NASA_EARTH_ASSETS
    {
        [JsonProperty("count")]
        public UInt32? Count { get; set; }

        [JsonProperty("results")]
        public NASA_EARTH_ASSETS_RESULT[] Results { get; set; }
    }

    #endregion

    #region "NASA Asteroids NeoWs (Neo Webservice)"

    #region "Neo Feed"

    public struct NASA_ASTEROIDS_FEED_LINKS
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Previous { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_DIAMETER_VALUES
    {
        [JsonProperty("estimated_diameter_min")]
        public double EstimatedDiameterMin { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double EstimatedDiameterMax { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_DIAMETER
    {
        [JsonProperty("kilometers")]
        public NASA_ASTEROIDS_FEED_DIAMETER_VALUES? Kilometers { get; set; }

        [JsonProperty("meters")]
        public NASA_ASTEROIDS_FEED_DIAMETER_VALUES? Meters { get; set; }

        [JsonProperty("miles")]
        public NASA_ASTEROIDS_FEED_DIAMETER_VALUES? Miles { get; set; }

        [JsonProperty("feet")]
        public NASA_ASTEROIDS_FEED_DIAMETER_VALUES? Feets { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_APPROACH_RELATIVE_VELOCITY
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }

        [JsonProperty("miles_per_hour")]
        public string MilesPerHour { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_MISS_DISTANCE
    {
        [JsonProperty("astronomical")]
        public string Astronomical { get; set; }

        [JsonProperty("lunar")]
        public string Lunar { get; set; }

        [JsonProperty("kilometers")]
        public string Kilometers { get; set; }

        [JsonProperty("miles")]
        public string Miles { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_CLOSE_APPROACH_DATA
    {
        [JsonProperty("close_approach_date")]
        public DateTime? CloseApproachDate { get; set; }

        [JsonProperty("close_approach_date_full")]
        public string CloseApproachDateFull { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public long EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public NASA_ASTEROIDS_FEED_APPROACH_RELATIVE_VELOCITY? RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public NASA_ASTEROIDS_FEED_MISS_DISTANCE? MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_ORBIT_CLASS
    {
        [JsonProperty("orbit_class_type")]
        public string OrbitClassType { get; set; }

        [JsonProperty("orbit_class_description")]
        public string OrbitClassDescription { get; set; }

        [JsonProperty("orbit_class_range")]
        public string OrbitClassRange { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_ORBITAL_DATA
    {
        [JsonProperty("orbit_id")]
        public string OrbitId { get; set; }

        [JsonProperty("orbit_determination_date")]
        public DateTime? OrbitDeterminationDate { get; set; }

        [JsonProperty("first_observation_date")]
        public DateTime? FirstObservationDate { get; set; }

        [JsonProperty("last_observation_date")]
        public DateTime? LastObservationDate { get; set; }

        [JsonProperty("data_arc_in_days")]
        public UInt32? DataArcInDays { get; set; }

        [JsonProperty("observations_used")]
        public UInt32? ObservationsUsed { get; set; }

        [JsonProperty("orbit_uncertainty")]
        public string OrbitUncertainty { get; set; }

        [JsonProperty("minimum_orbit_intersection")]
        public string MinimumOrbitIntersection { get; set; }

        [JsonProperty("jupiter_tisserand_invariant")]
        public string JupiterTisserandInvariant { get; set; }

        [JsonProperty("epoch_osculation")]
        public string EpochOsculation { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("semi_major_axis")]
        public string SemiMajorAxis { get; set; }

        [JsonProperty("inclination")]
        public string Inclination { get; set; }

        [JsonProperty("ascending_node_longitude")]
        public string AscendingNodeLongitude { get; set; }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod { get; set; }

        [JsonProperty("perihelion_distance")]
        public string PerihelionDistance { get; set; }

        [JsonProperty("perihelion_argument")]
        public string PerihelionArgument { get; set; }

        [JsonProperty("aphelion_distance")]
        public string AphelionDistance { get; set; }

        [JsonProperty("perihelion_time")]
        public string PerihelionTime { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("equinox")]
        public string Equinox { get; set; }

        [JsonProperty("orbit_class")]
        public NASA_ASTEROIDS_FEED_ORBIT_CLASS? OrbitClass { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_NEO
    {
        [JsonProperty("links")]
        public NASA_ASTEROIDS_FEED_LINKS? Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitudeH { get; set; }

        [JsonProperty("estimated_diameter")]
        public NASA_ASTEROIDS_FEED_DIAMETER? EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public NASA_ASTEROIDS_FEED_CLOSE_APPROACH_DATA[] CloseApproachData { get; set; }

        [JsonProperty("orbital_data")]
        public NASA_ASTEROIDS_FEED_ORBITAL_DATA? OrbitalData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }
    }

    public struct NASA_ASTEROIDS_FEED_DATA
    {
        [JsonProperty("links")]
        public NASA_ASTEROIDS_FEED_LINKS? Links { get; set; }

        [JsonProperty("element_count")]
        public UInt32? ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public Dictionary<string, List<NASA_ASTEROIDS_FEED_NEO>> NearEarthObjects { get; set; }
    }

    #endregion

    #region "Neo Browse"

    public struct NASA_ASTEROIDS_BROWSE_PAGE
    {
        [JsonProperty("size")]
        public UInt32? Size { get; set; }

        [JsonProperty("total_elements")]
        public UInt32? TotalElements { get; set; }

        [JsonProperty("total_pages")]
        public UInt32? TotalPages { get; set; }

        [JsonProperty("number")]
        public UInt32? Number { get; set; }
    }

    public struct NASA_ASTEROIDS_BROWSE_DATA
    {
        [JsonProperty("links")]
        public NASA_ASTEROIDS_FEED_LINKS? Links { get; set; }
        
        [JsonProperty("page")]
        public NASA_ASTEROIDS_BROWSE_PAGE? Page { get; set; }

        [JsonProperty("near_earth_objects")]
        public NASA_ASTEROIDS_FEED_NEO[] NearEarthObjects { get; set; }
    }

    #endregion

    #region "Neo Sentry"

    public struct NASA_ASTEROIDS_SENTRY_LINKS
    {
        [JsonProperty("near_earth_object_parent")]
        public string NearEarthObjectParent { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public struct NASA_ASTEROIDS_SENTRY_OBJECT
    {
        [JsonProperty("links")]
        public NASA_ASTEROIDS_SENTRY_LINKS Links { get; set; }

        [JsonProperty("spkId")]
        public string SpkId { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("sentryId")]
        public string SentryId { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("year_range_min")]
        public string YearRangeMin { get; set; }

        [JsonProperty("year_range_max")]
        public string YearRangeMax { get; set; }

        [JsonProperty("potential_impacts")]
        public long PotentialImpacts { get; set; }

        [JsonProperty("impact_probability")]
        public double ImpactProbability { get; set; }

        [JsonProperty("v_infinity")]
        public double V_Infinity { get; set; }

        [JsonProperty("absolute_magnitude")]
        public double AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public double EstimatedDiameter { get; set; }

        [JsonProperty("palermo_scale_ave")]
        public double PalermoScaleAve { get; set; }

        [JsonProperty("Palermo_scale_max")]
        public double PalermoScaleMax { get; set; }

        [JsonProperty("torino_scale")]
        public string TorinoScale { get; set; }

        [JsonProperty("last_obs")]
        public string LastObs { get; set; }

        [JsonProperty("last_obs_jd")]
        public string LastObs_jd { get; set; }

        [JsonProperty("url_nasa_details")]
        public string UrlNasaDetails { get; set; }

        [JsonProperty("url_orbital_elements")]
        public string UrlOrbitalElements { get; set; }

        [JsonProperty("is_active_sentry_object")]
        public bool IsActiveSentryObject { get; set; }

        [JsonProperty("average_lunar_distance")]
        public double AverageLunarDistance { get; set; }
    }

    public struct NASA_ASTEROIDS_SENTRY_DATA
    {
        [JsonProperty("links")]
        public NASA_ASTEROIDS_FEED_LINKS Links { get; set; }

        [JsonProperty("page")]
        public NASA_ASTEROIDS_BROWSE_PAGE Page { get; set; }

        [JsonProperty("sentry_objects")]
        public NASA_ASTEROIDS_SENTRY_OBJECT[] SentryObjects { get; set; }
    }

    #endregion

    #region "Neo Stats"

    public struct NASA_ASTEROIDS_NEO_STATS
    {
        [JsonProperty("near_earth_object_count")]
        public long NeoCount { get; set; }

        [JsonProperty("close_approach_count")]
        public long CloseApproachCount { get; set; }

        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }
    }

    #endregion

    #endregion

    public class NasaApod : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaApod(String apiKey, SecurityProtocolType secureProtocolType, DateTime? date = null, bool highQuality = true) : base(apiKey, secureProtocolType)
        {
            IsConnected = false;
            ApodHighQuality = highQuality;
            if (date == null)
            {
                ApodDate = DateTime.Today;
            }
            else
            {
                ApodDate = date.Value;
            }
        }

        public DateTime ApodDate { get; set; }
        public bool ApodHighQuality { get; set; }
        public bool IsConnected { get; private set; }

        public async Task Connect()
        {
            if (IsConnected == false)
            {
                IsConnected = true;
                secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_APOD, SecureProtocolType, SecureCookieContainer);
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync("date=" + ApodDate.ToString("yyyy-MM-dd") + "&hd=" + Convert.ToString(ApodHighQuality) + "&api_key=" + ApiKey);
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_APOD_DATA>(await packetInfo.PacketAsyncTask);
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                        throw new Exception("The async connection has failed with status: " + (ushort)packetInfo.PacketStatus);
                    }
                }
            }
        }

        public async Task Update()
        {
            if (IsConnected == true)
            {
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync("date=" + ApodDate.ToString("yyyy-MM-dd") + "&hd=" + Convert.ToString(ApodHighQuality) + "&api_key=" + ApiKey);
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_APOD_DATA>(await packetInfo.PacketAsyncTask);
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                    }
                }
            }
        }

        public void Close()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                secureConnection.Dispose();
                DataBuffer = new NASA_APOD_DATA();
            }
        }

        public NASA_APOD_DATA DataBuffer { get; private set; }

    }

    public class NasaMars : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaMars(String apiKey, SecurityProtocolType secureProtocolType, int sol = -1, String camera = null, int page = 1, DateTime? earthDate = null) : base(apiKey, secureProtocolType)
        {
            IsConnected = false;
            Sol = sol;
            Camera = camera;
            Page = page;
            if (earthDate == null)
            {
                EarthDate = DateTime.Today;
            }
            else
            {
                EarthDate = earthDate.Value;
            }
        }

        public DateTime EarthDate { get; set; }
        public int Sol { get; set; }
        public string Camera { get; set; }
        public int Page { get; set; }
        public bool IsConnected { get; private set; }

        private void QueryAddParameter(ref string queryString, string parameter, object value, object defaultValue, bool useDefaultValue)
        {
            if (queryString != string.Empty)
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += "&" + parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += "&" + parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
            else
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
        }

        private string MarsCall(DateTime earth_date, string camera, int page, string api_key, int sol)
        {
            string apiCall = string.Empty;
            QueryAddParameter(ref apiCall, "earth_date", earth_date.ToString("yyyy-MM-dd"), null, false);
            QueryAddParameter(ref apiCall, "camera", camera, null, false);
            QueryAddParameter(ref apiCall, "page", page, 1, true);
            QueryAddParameter(ref apiCall, "sol", sol, null, false);
            QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
            return apiCall;
        }

        public async Task Connect()
        {
            if (IsConnected == false)
            {
                IsConnected = true;
                secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_MRP, SecureProtocolType, SecureCookieContainer);
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(MarsCall(EarthDate, Camera, Page, ApiKey, Sol));
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_MARS_DATA>(await packetInfo.PacketAsyncTask);
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                        throw new Exception("The async connection has failed with status: " + (ushort)packetInfo.PacketStatus);
                    }
                }
            }
        }

        public async Task Update()
        {
            if (IsConnected == true)
            {
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(MarsCall(EarthDate, Camera, Page, ApiKey, Sol));
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_MARS_DATA>(await packetInfo.PacketAsyncTask);
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                    }
                }
            }
        }

        public void Close()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                secureConnection.Dispose();
                DataBuffer = new NASA_MARS_DATA();
            }
        }

        public NASA_MARS_DATA DataBuffer { get; private set; }

    }

    public class NasaGeneLab : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaGeneLab(string apiKey, SecurityProtocolType secureProtocolType,
                            string term = null, string type = "cgene", uint from = 0,
                            uint size = 25, string sort = null, string order = "DESC",
                            string ffield = null, string fvalue = null) : base(apiKey, secureProtocolType)
        {
            Term = term;
            Type = type;
            From = from;
            Size = size;
            Sort = sort;
            Order = order;
            FilterField = ffield;
            FilterValue = fvalue;
            //MessageBox.Show(GeneLabCall(term, type, from, size, sort, order, ffield, fvalue));
        }

        public string Term { get; set; }
        public string Type { get; set; }
        public uint From { get; set; }
        public uint Size { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }
        public string FilterField { get; set; }
        public string FilterValue { get; set; }
        public bool IsConnected { get; private set; }

        private void QueryAddParameter(ref string queryString, string parameter, object value, object defaultValue, bool useDefaultValue)
        {
            if (queryString != string.Empty)
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += "&" + parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += "&" + parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
            else
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
        }

        private string GeneLabCall(string term, string type, uint from, uint size, string sort, string order, string ffield, string fvalue)
        {
            string apiCall = string.Empty;
            QueryAddParameter(ref apiCall, "term", term, null, false);
            QueryAddParameter(ref apiCall, "type", type, "cgene", true);
            QueryAddParameter(ref apiCall, "from", from, 0, true);
            QueryAddParameter(ref apiCall, "size", size, 25, true);
            QueryAddParameter(ref apiCall, "sort", sort, null, false);
            QueryAddParameter(ref apiCall, "order", order, "DESC", true);
            QueryAddParameter(ref apiCall, "ffield", ffield, null, false);
            QueryAddParameter(ref apiCall, "fvalue", fvalue, null, false);
            QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
            return apiCall;
        }

        public async Task Connect()
        {
            if (IsConnected == false)
            {
                IsConnected = true;
                secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_GENELAB, SecureProtocolType, SecureCookieContainer);
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(GeneLabCall(Term, Type, From, Size, Sort, Order, FilterField, FilterValue));
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_GENELAB_DATA>(await packetInfo.PacketAsyncTask);
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                        throw new Exception("The async connection has failed with status: " + (ushort)packetInfo.PacketStatus);
                    }
                }
            }
        }

        public async Task Update()
        {
            if (IsConnected == true)
            {
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(GeneLabCall(Term, Type, From, Size, Sort, Order, FilterField, FilterValue));
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_GENELAB_DATA>(await packetInfo.PacketAsyncTask);
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                    }
                }
            }
        }

        public void Close()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                secureConnection.Dispose();
                DataBuffer = new NASA_GENELAB_DATA();
            }
        }

        public NASA_GENELAB_DATA DataBuffer { get; private set; }
    }

    public class NasaEpic : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaEpic(string apiKey, SecurityProtocolType secureProtocolType,
                        NASA_EPIC_REQUEST_TYPE requestType =
                        NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_RECENT,
                        DateTime? date = null) : base(apiKey, secureProtocolType)
        {
            IsConnected = false;
            EpicRequestType = requestType;
            if (date.HasValue == true)
            {
                EpicImageDate = date.Value;
            }
            else
            {
                EpicImageDate = DateTime.Today;
            }
        }

        public NASA_EPIC_REQUEST_TYPE EpicRequestType { get; set; }
        public DateTime EpicImageDate { get; set; }
        public bool IsConnected { get; private set; }

        public string EpicCall(NASA_EPIC_REQUEST_TYPE requestType, DateTime date)
        {
            string apiCall = string.Empty;
            switch (requestType)
            {
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_RECENT:
                    apiCall = "/natural?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_DATE:
                    apiCall = "/natural/date/" + EpicImageDate.ToString("yyyy-MM-dd") + "?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_ALL:
                    apiCall = "/natural/all?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_AVAILABLE:
                    apiCall = "/natural/available?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_RECENT:
                    apiCall = "/enhanced?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_DATE:
                    apiCall = "/enhanced/date/" + EpicImageDate.ToString("yyyy-MM-dd") + "?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_ALL:
                    apiCall = "/enhanced/all?api_key=" + ApiKey;
                    break;
                case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_AVAILABLE:
                    apiCall = "/enhanced/available?api_key=" + ApiKey;
                    break;
            }
            return apiCall;
        }

        public async Task Connect()
        {
            if (IsConnected == false)
            {
                IsConnected = true;
                secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_EPIC + EpicCall(EpicRequestType, EpicImageDate), SecureProtocolType, SecureCookieContainer);
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(string.Empty);
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.
                        
                        switch (EpicRequestType)
                        {
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_RECENT:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<NASA_EPIC_DATA>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_DATE:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<NASA_EPIC_DATA>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_ALL:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<NASA_EPIC_DATE_STRUCTURE>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_NATURAL_AVAILABLE:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<DateTime>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_RECENT:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<NASA_EPIC_DATA>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_DATE:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<NASA_EPIC_DATA>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_ALL:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<NASA_EPIC_DATE_STRUCTURE>>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EPIC_REQUEST_TYPE.NASA_EPIC_ENHANCED_AVAILABLE:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<List<DateTime>>(await packetInfo.PacketAsyncTask);
                                break;
                        }

                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                        throw new Exception("The async connection has failed with status: " + (ushort)packetInfo.PacketStatus);
                    }
                }
            }
        }

        public async Task Update()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                await Connect();
            }
            else
            {
                await Connect();
            }
        }

        public void Close()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                secureConnection.Dispose();
                DataBuffer = new object();
            }
        }

        public object DataBuffer { get; private set; }

    }

    public class NasaAsteroids : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaAsteroids(string apiKey, SecurityProtocolType secureProtocolType,
            NASA_ASTEROIDS_REQUEST_TYPE neoWsRequestType, DateTime? startDate = null,
            DateTime? endDate = null, bool feedDetailed = true, bool isActive = true,
            string asteroidId = null, UInt32 page = 0, UInt32 size = 50) : base(apiKey, secureProtocolType)
        {
            IsConnected = false;
            RequestType = neoWsRequestType;
            if (startDate.HasValue)
            {
                StartDate = startDate.Value;
            }
            if (endDate.HasValue)
            {
                EndDate = endDate.Value;
            }
            FeedDetailed = feedDetailed;
            IsActiveSentry = isActive;
            AsteroidId = asteroidId;
            Page = page;
            Size = size;
        }

        public NASA_ASTEROIDS_REQUEST_TYPE RequestType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool FeedDetailed { get; set; }
        public bool IsActiveSentry { get; set; }
        public string AsteroidId { get; set; }
        public UInt32 Page { get; set; }
        public UInt32 Size { get; set; }
        public bool IsConnected { get; private set; }

        private void QueryAddParameter(ref string queryString, string parameter, object value, object defaultValue, bool useDefaultValue)
        {
            if (queryString != string.Empty)
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += "&" + parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += "&" + parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
            else
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
        }

        private string NeoWsAddress(string asteroidId = null)
        {
            string NeoWsAddr = NasaAddresses.NASA_ADDRESS_ASTEROIDS;
            switch (RequestType)
            {
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_FEED:
                    NeoWsAddr += "/rest/v1/feed";
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_FEED_TODAY:
                    NeoWsAddr += "/rest/v1/feed/today";
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_SENTRY:
                    NeoWsAddr += "/rest/v1/neo/sentry";
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_SENTRY_ID:
                    if (asteroidId != null) { NeoWsAddr += "/rest/v1/neo/sentry/"; }
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_BROWSE:
                    NeoWsAddr += "/rest/v1/neo/browse";
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_ASTEROID_ID:
                    if (asteroidId != null) { NeoWsAddr += "/rest/v1/neo/"; }
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_STATS:
                    NeoWsAddr += "/rest/v1/stats";
                    break;
            }
            return NeoWsAddr;
        }

        private string NeoWsCall()
        {
            string apiCall = string.Empty;
            switch (RequestType)
            {
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_FEED:
                    if (StartDate.Ticks > 0)
                    {
                        QueryAddParameter(ref apiCall, "start_date", StartDate.ToString("yyyy-MM-dd"), null, false);
                    }
                    if (EndDate.Ticks > 0)
                    {
                        QueryAddParameter(ref apiCall, "start_date", EndDate.ToString("yyyy-MM-dd"), null, false);
                    }
                    QueryAddParameter(ref apiCall, "detailed", FeedDetailed, true, true);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_FEED_TODAY:
                    QueryAddParameter(ref apiCall, "detailed", FeedDetailed, true, true);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_SENTRY:
                    QueryAddParameter(ref apiCall, "is_active", IsActiveSentry, true, true);
                    QueryAddParameter(ref apiCall, "page", Page, 0, true);
                    QueryAddParameter(ref apiCall, "size", Size, 50, true);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_SENTRY_ID:
                    QueryAddParameter(ref apiCall, "asteroid_id", AsteroidId, null, false);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_BROWSE:
                    QueryAddParameter(ref apiCall, "page", Page, 0, true);
                    QueryAddParameter(ref apiCall, "size", Size, 50, true);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_ASTEROID_ID:
                    QueryAddParameter(ref apiCall, "asteroid_id", AsteroidId, null, false);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_ASTEROIDS_REQUEST_TYPE.NEO_STATS:
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
            }
            return apiCall;
        }

        public async Task Connect()
        {
            if (IsConnected == false)
            {
                IsConnected = true;
                secureConnection = new NasaSecureHttpRequest(NeoWsAddress(AsteroidId), SecureProtocolType, SecureCookieContainer);
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(NeoWsCall());
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.

                        switch (RequestType)
                        {
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_FEED:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_FEED_DATA>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_FEED_TODAY:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_FEED_DATA>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_SENTRY:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_SENTRY_DATA>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_SENTRY_ID:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_SENTRY_OBJECT>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_BROWSE:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_BROWSE_DATA>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_ASTEROID_ID:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_FEED_NEO>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_ASTEROIDS_REQUEST_TYPE.NEO_STATS:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_ASTEROIDS_NEO_STATS>(await packetInfo.PacketAsyncTask);
                                break;
                        }
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                        throw new Exception("The async connection has failed with status: " + (ushort)packetInfo.PacketStatus);
                    }
                }
            }
        }

        public async Task Update()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                await Connect();
            }
            else
            {
                await Connect();
            }
        }

        public void Close()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                secureConnection.Dispose();
                DataBuffer = new object();
            }
        }

        public object DataBuffer { get; private set; }

    }

    public class NasaDonki : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaDonki(string apiKey, SecurityProtocolType secureProtocolType,
                        DateTime? startDate = null, DateTime? endDate = null,
                        bool mostAccurateOnly = true, bool completeEntryOnly = true,
                        Int32 speed = 0, Int32 halfAngle = 0, string catalog = "ALL",
                        string keyword = null, string location = "ALL") : base(apiKey, secureProtocolType)
        {

        }

    } //terminar essa classe

    public class NasaEarth : NasaConnection
    {
        NasaSecureHttpRequest secureConnection;

        public NasaEarth(String apiKey, SecurityProtocolType secureProtocolType, NASA_EARTH_REQUEST_TYPE requestType, double latitude, double longitude, DateTime? date = null, double sizeInDegrees = 0.025, bool cloudScore = false, DateTime? beginsearchDate = null, DateTime? endsearchDate = null) : base(apiKey, secureProtocolType)
        {
            IsConnected = false;
            RequestType = requestType;
            EarthLatitude = latitude;
            EarthLongitude = longitude;
            if (date.HasValue) {
                EarthDate = date.Value;
            }
            ImageSizeInDegrees = sizeInDegrees;
            ImageCloudScore = cloudScore;
            if (beginsearchDate.HasValue){
                BeginSearchDate = beginsearchDate.Value;
            }
            if (endsearchDate.HasValue){
                EndSearchDate = endsearchDate.Value;
            }
        }

        public DateTime EarthDate { get; set; }
        public DateTime BeginSearchDate { get; set; }
        public DateTime EndSearchDate { get; set; }
        public double EarthLatitude { get; set; }
        public double EarthLongitude { get; set; }
        public double ImageSizeInDegrees { get; set; }
        public bool ImageCloudScore { get; set; }
        public bool IsConnected { get; private set; }
        public NASA_EARTH_REQUEST_TYPE RequestType { get; set; }

        private void QueryAddParameter(ref string queryString, string parameter, object value, object defaultValue, bool useDefaultValue)
        {
            if (queryString != string.Empty)
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += "&" + parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += "&" + parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
            else
            {
                if (Convert.ToString(value) != Convert.ToString(defaultValue))
                {
                    queryString += parameter + "=" + value;
                }
                else
                {
                    if (useDefaultValue == true)
                    {
                        queryString += parameter + "=" + Convert.ToString(defaultValue);
                    }
                }
            }
        }

        private string EarthCall(double latitude, double longitude, DateTime date, DateTime beginsearchDate, DateTime endsearchDate, double sizeInDegrees, bool cloudScore = false)
        {
            string apiCall = string.Empty;
            switch (RequestType)
            {
                case NASA_EARTH_REQUEST_TYPE.NASA_EARTH_IMAGERY:
                    QueryAddParameter(ref apiCall, "lat", latitude.ToString().Replace(',', '.'), null, false);
                    QueryAddParameter(ref apiCall, "lon", longitude.ToString().Replace(',', '.'), null, false);
                    if (date.Ticks > 0){
                        QueryAddParameter(ref apiCall, "date", date.ToString("yyyy-MM-dd"), null, false);
                    }
                    QueryAddParameter(ref apiCall, "cloud_score", cloudScore.ToString().ToLower(), "false", true);
                    QueryAddParameter(ref apiCall, "dim", sizeInDegrees.ToString().Replace(',', '.'), "0.025", true);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                case NASA_EARTH_REQUEST_TYPE.NASA_EARTH_ASSETS:
                    QueryAddParameter(ref apiCall, "lat", latitude.ToString().Replace(',', '.'), null, false);
                    QueryAddParameter(ref apiCall, "lon", longitude.ToString().Replace(',', '.'), null, false);
                    if (beginsearchDate.Ticks > 0){
                        QueryAddParameter(ref apiCall, "begin", beginsearchDate.ToString("yyyy-MM-dd"), null, false);
                    }
                    if (endsearchDate.Ticks > 0){
                        QueryAddParameter(ref apiCall, "end", endsearchDate.ToString("yyyy-MM-dd"), null, false);
                    }
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
                default:
                    QueryAddParameter(ref apiCall, "lat", latitude.ToString().Replace(',', '.'), null, false);
                    QueryAddParameter(ref apiCall, "lon", longitude.ToString().Replace(',', '.'), null, false);
                    if (date.Ticks > 0){
                        QueryAddParameter(ref apiCall, "date", date.ToString("yyyy-MM-dd"), null, false);
                    }
                    QueryAddParameter(ref apiCall, "cloud_score", cloudScore.ToString().ToLower(), "false", true);
                    QueryAddParameter(ref apiCall, "dim", sizeInDegrees.ToString().Replace(',', '.'), "0.025", true);
                    QueryAddParameter(ref apiCall, "api_key", ApiKey, null, true);
                    break;
            }
            return apiCall;
        }

        public async Task Connect()
        {
            if (IsConnected == false)
            {
                IsConnected = true;
                switch (RequestType)
                {
                    case NASA_EARTH_REQUEST_TYPE.NASA_EARTH_IMAGERY:
                        secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_EARTH + "/imagery/", SecureProtocolType, SecureCookieContainer);
                        break;
                    case NASA_EARTH_REQUEST_TYPE.NASA_EARTH_ASSETS:
                        secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_EARTH + "/assets", SecureProtocolType, SecureCookieContainer);
                        break;
                    default:
                        secureConnection = new NasaSecureHttpRequest(NasaAddresses.NASA_ADDRESS_EARTH + "/imagery/", SecureProtocolType, SecureCookieContainer);
                        break;
                }
                using (NasaSecureHttpRequest nasaHttpReq = secureConnection)
                {
                    NASA_PACKET_INFO packetInfo = nasaHttpReq.GetAsync(EarthCall(EarthLatitude, EarthLongitude, EarthDate, BeginSearchDate, EndSearchDate, ImageSizeInDegrees, ImageCloudScore));
                    if (packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_SUCCESS || packetInfo.PacketStatus == NASA_STATUS.NASA_REQUEST_PENDING)
                    {
                        //Sucesso na requisição ao servidor.
                        //Conexão assíncrona.

                        switch (RequestType)
                        {
                            case NASA_EARTH_REQUEST_TYPE.NASA_EARTH_IMAGERY:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_EARTH_DATA>(await packetInfo.PacketAsyncTask);
                                break;
                            case NASA_EARTH_REQUEST_TYPE.NASA_EARTH_ASSETS:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_EARTH_ASSETS>(await packetInfo.PacketAsyncTask);
                                break;
                            default:
                                DataBuffer = await JsonConvert.DeserializeObjectAsync<NASA_EARTH_DATA>(await packetInfo.PacketAsyncTask);
                                break;
                        }
                        
                    }
                    else
                    {
                        //A requisição falhou.
                        IsConnected = false;
                        throw new Exception("The async connection has failed with status: " + (ushort)packetInfo.PacketStatus);
                    }
                }
            }
        }

        public async Task Update()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                await Connect();
            }
            else
            {
                await Connect();
            }
        }

        public void Close()
        {
            if (IsConnected == true)
            {
                IsConnected = false;
                secureConnection.Dispose();
                DataBuffer = new object();
            }
        }

        public object DataBuffer { get; private set; }

    }

}
