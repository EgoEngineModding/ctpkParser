using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib
{
    public class CatalogueObjects
    {
        UInt32 _nSections;
        CTPKLib _lib;

        Dictionary<UInt32, List<CatalogueObject>> _objects;
        Dictionary<UInt32, Type> _objectTypes;

        public CatalogueObjects(CTPKLib lib, BinaryReader r)
        {
            _lib = lib;

            var types = Assembly.GetExecutingAssembly()
                                         .GetTypes()
                                         .Where(t => t.IsSubclassOf(typeof(CatalogueObject)));

            _objectTypes = new Dictionary<uint, Type>(types.Count());
            foreach (var type in types)
            {
                Section sectionAttr = type.GetCustomAttribute<Section>();

                if (sectionAttr != null)
                    _objectTypes[sectionAttr.Id] = type;
            }

            _nSections = r.ReadUInt32();
            _objects = new Dictionary<uint, List<CatalogueObject>>((int)_nSections);

            for (int i = 0; i < _nSections; i++)
            {
                UInt32 sectionId = r.ReadUInt32();
                UInt32 sectionOffset = r.ReadUInt32();

                if (sectionOffset == 0xFFFFFFFF)
                    continue;

                long pos = r.BaseStream.Position;

                r.BaseStream.Seek(sectionOffset, SeekOrigin.Begin);
                UInt32 nObjects = r.ReadUInt32();

                List<CatalogueObject> obj = new List<CatalogueObject>((int)nObjects);
                for (int j = 0; j < nObjects; j++)
                {
                    obj.Add(MakeObject(_lib, sectionId, r));
                }
                _objects[sectionId] = obj;

                r.BaseStream.Seek(pos, SeekOrigin.Begin);
            }

            foreach (string name in _objectNames)
            {
                lib.Strings.AddString(name);
            }
            
        }


        public CatalogueObject MakeObject(CTPKLib lib, UInt32 sectionId, BinaryReader r)
        {
            Type targetType;

            var pos = r.BaseStream.Position;
            if (!_objectTypes.TryGetValue(sectionId, out targetType))
                return new CatalogueObject(lib, sectionId, r);

            try
            {
                return Activator.CreateInstance(targetType, lib, sectionId, r) as CatalogueObject;
            }
            catch (Exception)
            {
                r.BaseStream.Seek(pos, SeekOrigin.Begin);
                return new CatalogueObject(lib, sectionId, r);
            }
        }

        static public CatalogueObject MakeObjectStatic(CTPKLib lib, UInt32 sectionId, BinaryReader r)
        {
            var targetType = Assembly.GetExecutingAssembly()
                         .GetTypes()
                         .Where(t => t.IsSubclassOf(typeof(CatalogueObject)) &&
                                t.GetCustomAttribute<Section>()?.Id == sectionId)
                         .FirstOrDefault();

            var pos = r.BaseStream.Position;
            if (targetType == null)
                return new CatalogueObject(lib, sectionId, r);

            try
            {
                return Activator.CreateInstance(targetType, lib, sectionId, r) as CatalogueObject;
            }
            catch (Exception)
            {
                r.BaseStream.Seek(pos, SeekOrigin.Begin);
                return new CatalogueObject(lib, sectionId, r);
            }
        }

        public Type getSectionType(UInt32 sectionId)
        {
            Type t;
            if (_objectTypes.TryGetValue(sectionId, out t))
                return t;

            return null;
        }

        public Dictionary<UInt32, List<CatalogueObject>> ObjectMap { get { return _objects; } }

        private readonly string[] _objectNames =
        {
           "activity_feed",
            "ai_driver",
            "ai_driver_levels",
            "ai_penalty_type",
            "announcement_link",
            "audio_name",
            "career_championship",
            "career_championship_class",
            "career_championship_difficulty",
            "career_discipline",
            "career_event",
            "career_event_rewards",
            "career_license",
            "career_stage",
            "career_tier",
            "championship_format",
            "character_type",
            "characters",
            "components",
            "country",
            "crowd_location",
            "crowd_type",
            "currency",
            "data_types",
            "difficulty",
            "difficulty_hardcore_damage",
            "difficulty_option",
            "difficulty_preset",
            "difficulty_preset_abs",
            "difficulty_preset_ai",
            "difficulty_preset_hud",
            "difficulty_preset_otb",
            "difficulty_preset_restarts",
            "difficulty_preset_st_cont",
            "difficulty_preset_tcb",
            "difficulty_preset_tr_cont",
            "difficulty_preset_transmission",
            "difficulty_rewards",
            "difficulty_settings",
            "difficulty_spreads",
            "discipline",
            "distribution_curves",
            "distribution_curves",
            "driver",
            "driver_level",
            "driver_punctures",
            "durable_entitlement",
            "engine_type",
            "engineer",
            "engineer_perk",
            "engineer_slot",
            "entitlement_item",
            "entitlement_relations",
            "event_news",
            "event_news_category",
            "event_news_discipline",
            "event_news_location",
            "event_news_settings",
            "facility",
            "facility_type",
            "fearless_bonus",
            "fearless_moment",
            "finish_condition",
            "game_mode",
            "game_mode_track",
            "handling_model",
            "joyride_challenge",
            "lesson",
            "lesson_category",
            "lesson_layers",
            "lesson_race_type",
            "lesson_subtitles",
            "lesson_triggers",
            "lesson_type",
            "location",
            "location_conditions",
            "lock_table",
            "loot_box",
            "manufacturer",
            "meta_type",
            "nationality",
            "net_race_type",
            "object_templates",
            "pace_targets",
            "package_type",
            "packages",
            "penalties",
            "penalty_type",
            "perk",
            "perk_slot",
            "piecewise_curves",
            "player_icon",
            "product",
            "product_item",
            "quality_grade",
            "race_format",
            "race_type",
            "rally_event",
            "rallycross_event_format",
            "reputation_rank",
            "reset_type",
            "reset_type_restrictions",
            "result_types",
            "reward_token",
            "season",
            "season_pass",
            "session_result_types",
            "sponsor",
            "sponsor_categories",
            "sponsor_decal",
            "sponsor_grade",
            "spotter",
            "staff_co_driver",
            "staff_engineer",
            "staff_engineer_perks",
            "staff_language",
            "staff_pool",
            "staff_roster",
            "staff_rx_spotter",
            "staff_traits",
            "staff_traits_addressed",
            "staff_traits_addressed_layers",
            "staff_upgrades",
            "stage_conditions",
            "start_type",
            "stats",
            "stats_categories",
            "stats_groups",
            "stats_types",
            "target_owner",
            "target_type",
            "team",
            "team_grade",
            "team_preset",
            "track",
            "track_model",
            "track_model_surface",
            "track_model_surface_degradation",
            "track_status",
            "track_type",
            "tuning_units",
            "tyre_compound",
            "tyre_type",
            "unexpected_moments_option",
            "units",
            "unlock_objectives",
            "unlock_type",
            "vehicle",
            "vehicle_availability",
            "vehicle_class",
            "vehicle_class_discipline",
            "vehicle_interior",
            "vehicle_level",
            "vehicle_livery",
            "vehicle_livery_palette",
            "vehicle_livery_pattern",
            "vehicle_livery_theme",
            "vehicle_livery_types",
            "vehicle_mod",
            "vehicle_model",
            "vehicle_part",
            "vehicle_part_category",
            "vehicle_part_template",
            "vehicle_part_type",
            "vehicle_redirect",
            "vehicle_tier",
            "vehicle_upgrades",
            "video",
            "zone"
        };
    }
}
