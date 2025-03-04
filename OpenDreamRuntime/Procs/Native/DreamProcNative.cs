﻿using OpenDreamRuntime.Objects;
using OpenDreamShared.Dream;
using Robust.Shared.IoC;

namespace OpenDreamRuntime.Procs.Native {
    static class DreamProcNative {
        public static void SetupNativeProcs(DreamObjectTree objectTree) {
            DreamProcNativeRoot.DreamManager = IoCManager.Resolve<IDreamManager>();

            DreamObjectDefinition root = objectTree.GetObjectDefinition(DreamPath.Root);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_abs);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_alert);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_animate);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_arccos);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_arcsin);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_arctan);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ascii2text);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ckey);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ckeyEx);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_clamp);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_cmptext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_copytext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_cos);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_CRASH);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_fcopy);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_fcopy_rsc);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_fdel);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_fexists);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_file);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_file2text);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_findtext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_findtextEx);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_findlasttext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_findlasttextEx);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_flick);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_flist);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_hascall);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_html_decode);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_html_encode);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_icon_states);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_image);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isarea);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isfile);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isicon);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_islist);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isloc);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ismob);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ismovable);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isnull);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isnum);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ispath);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_istext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_isturf);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_json_decode);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_json_encode);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_length);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_length_char);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_list2params);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_log);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_lowertext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_max);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_md5);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_min);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_nonspantext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_num2text);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_oview);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_oviewers);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_params2list);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_prob);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_rand);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_rand_seed);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_ref);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_regex);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_replacetext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_replacetextEx);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_rgb);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_rgb2num);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_roll);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_round);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_shutdown);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_sin);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_sleep);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_sorttext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_sorttextEx);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_sound);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_splittext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_sqrt);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_stat);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_statpanel);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_tan);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_text2ascii);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_text2file);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_text2num);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_text2path);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_time2text);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_typesof);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_uppertext);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_url_decode);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_url_encode);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_view);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_viewers);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_walk);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_walk_to);
            root.SetNativeProc(DreamProcNativeRoot.NativeProc_winset);

            DreamObjectDefinition list = objectTree.GetObjectDefinition(DreamPath.List);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Add);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Copy);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Cut);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Find);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Insert);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Remove);
            list.SetNativeProc(DreamProcNativeList.NativeProc_Swap);

            DreamObjectDefinition regex = objectTree.GetObjectDefinition(DreamPath.Regex);
            regex.SetNativeProc(DreamProcNativeRegex.NativeProc_Find);
            regex.SetNativeProc(DreamProcNativeRegex.NativeProc_Replace);

            //DreamObjectDefinition savefile = objectTree.GetObjectDefinitionFromPath(DreamPath.Savefile);
            //regex.SetNativeProc(DreamProcNativeSavefile.NativeProc_Flush);

            DreamObjectDefinition world = objectTree.GetObjectDefinition(DreamPath.World);
            world.SetNativeProc(DreamProcNativeWorld.NativeProc_Export);
        }
    }
}
