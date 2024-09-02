; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [246 x i32] [
	i32 11257817, ; 0: OxyPlot.dll => 0xabc7d9 => 11
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 66
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 100
	i32 39109920, ; 3: Newtonsoft.Json.dll => 0x254c520 => 10
	i32 39852199, ; 4: Plugin.Permissions => 0x26018a7 => 13
	i32 57263871, ; 5: Xamarin.Forms.Core.dll => 0x369c6ff => 93
	i32 101534019, ; 6: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 82
	i32 120558881, ; 7: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 82
	i32 134690465, ; 8: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 108
	i32 165246403, ; 9: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 43
	i32 182336117, ; 10: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 84
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 41
	i32 230216969, ; 12: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 60
	i32 232815796, ; 13: System.Web.Services => 0xde07cb4 => 121
	i32 261689757, ; 14: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 46
	i32 278686392, ; 15: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 64
	i32 280482487, ; 16: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 58
	i32 318968648, ; 17: Xamarin.AndroidX.Activity.dll => 0x13031348 => 33
	i32 321597661, ; 18: System.Numerics => 0x132b30dd => 27
	i32 342366114, ; 19: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 62
	i32 347068432, ; 20: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 20
	i32 385762202, ; 21: System.Memory.dll => 0x16fe439a => 25
	i32 441335492, ; 22: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 45
	i32 442521989, ; 23: Xamarin.Essentials => 0x1a605985 => 92
	i32 450948140, ; 24: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 57
	i32 465846621, ; 25: mscorlib => 0x1bc4415d => 9
	i32 469710990, ; 26: System.dll => 0x1bff388e => 24
	i32 476646585, ; 27: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 58
	i32 486930444, ; 28: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 70
	i32 525008092, ; 29: SkiaSharp.dll => 0x1f4afcdc => 14
	i32 526420162, ; 30: System.Transactions.dll => 0x1f6088c2 => 115
	i32 527452488, ; 31: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 108
	i32 605376203, ; 32: System.IO.Compression.FileSystem => 0x24154ecb => 119
	i32 627609679, ; 33: Xamarin.AndroidX.CustomView => 0x2568904f => 51
	i32 639843206, ; 34: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 56
	i32 663517072, ; 35: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 89
	i32 666292255, ; 36: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 38
	i32 690569205, ; 37: System.Xml.Linq.dll => 0x29293ff5 => 32
	i32 691348768, ; 38: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 110
	i32 696557860, ; 39: BasesDeDatosLocales.dll => 0x2984a124 => 2
	i32 700284507, ; 40: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 105
	i32 720511267, ; 41: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 109
	i32 748832960, ; 42: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 18
	i32 775507847, ; 43: System.IO.Compression => 0x2e394f87 => 118
	i32 809851609, ; 44: System.Drawing.Common.dll => 0x30455ad9 => 117
	i32 843511501, ; 45: Xamarin.AndroidX.Print => 0x3246f6cd => 77
	i32 886248193, ; 46: Microcharts.Droid => 0x34d31301 => 6
	i32 928116545, ; 47: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 100
	i32 955402788, ; 48: Newtonsoft.Json => 0x38f24a24 => 10
	i32 956575887, ; 49: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 109
	i32 967690846, ; 50: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 62
	i32 974778368, ; 51: FormsViewGroup.dll => 0x3a19f000 => 3
	i32 1012816738, ; 52: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 81
	i32 1035644815, ; 53: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 37
	i32 1042160112, ; 54: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 97
	i32 1052210849, ; 55: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 67
	i32 1084122840, ; 56: Xamarin.Kotlin.StdLib => 0x409e66d8 => 107
	i32 1098259244, ; 57: System => 0x41761b2c => 24
	i32 1104002344, ; 58: Plugin.Media => 0x41cdbd28 => 12
	i32 1137654822, ; 59: Plugin.Permissions.dll => 0x43cf3c26 => 13
	i32 1175144683, ; 60: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 87
	i32 1178241025, ; 61: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 74
	i32 1204270330, ; 62: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 38
	i32 1264511973, ; 63: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 83
	i32 1267360935, ; 64: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 88
	i32 1275534314, ; 65: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 110
	i32 1292207520, ; 66: SQLitePCLRaw.core.dll => 0x4d0585a0 => 19
	i32 1293217323, ; 67: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 53
	i32 1354490624, ; 68: Xamarin.Forms.GoogleMaps.dll => 0x50bbe300 => 95
	i32 1365406463, ; 69: System.ServiceModel.Internals.dll => 0x516272ff => 112
	i32 1371845985, ; 70: Xamarin.Forms.GoogleMaps.Android => 0x51c4b561 => 94
	i32 1376866003, ; 71: Xamarin.AndroidX.SavedState => 0x52114ed3 => 81
	i32 1395857551, ; 72: Xamarin.AndroidX.Media.dll => 0x5333188f => 71
	i32 1406073936, ; 73: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 47
	i32 1411638395, ; 74: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 29
	i32 1460219004, ; 75: Xamarin.Forms.Xaml => 0x57092c7c => 98
	i32 1462112819, ; 76: System.IO.Compression.dll => 0x57261233 => 118
	i32 1469204771, ; 77: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 36
	i32 1582372066, ; 78: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 52
	i32 1582526884, ; 79: Microcharts.Forms.dll => 0x5e5371a4 => 7
	i32 1592978981, ; 80: System.Runtime.Serialization.dll => 0x5ef2ee25 => 1
	i32 1622152042, ; 81: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 69
	i32 1624863272, ; 82: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 91
	i32 1635184631, ; 83: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 56
	i32 1636350590, ; 84: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 50
	i32 1639515021, ; 85: System.Net.Http.dll => 0x61b9038d => 26
	i32 1657153582, ; 86: System.Runtime => 0x62c6282e => 30
	i32 1658241508, ; 87: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 85
	i32 1658251792, ; 88: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 99
	i32 1670060433, ; 89: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 46
	i32 1698840827, ; 90: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 106
	i32 1711441057, ; 91: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 20
	i32 1722051300, ; 92: SkiaSharp.Views.Forms => 0x66a46ae4 => 16
	i32 1729485958, ; 93: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 42
	i32 1766324549, ; 94: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 84
	i32 1776026572, ; 95: System.Core.dll => 0x69dc03cc => 23
	i32 1788241197, ; 96: Xamarin.AndroidX.Fragment => 0x6a96652d => 57
	i32 1808609942, ; 97: Xamarin.AndroidX.Loader => 0x6bcd3296 => 69
	i32 1813058853, ; 98: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 107
	i32 1813201214, ; 99: Xamarin.Google.Android.Material => 0x6c13413e => 99
	i32 1818569960, ; 100: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 75
	i32 1867746548, ; 101: Xamarin.Essentials.dll => 0x6f538cf4 => 92
	i32 1878053835, ; 102: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 98
	i32 1885316902, ; 103: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 39
	i32 1908813208, ; 104: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 102
	i32 1919157823, ; 105: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 72
	i32 1983156543, ; 106: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 106
	i32 2011961780, ; 107: System.Buffers.dll => 0x77ec19b4 => 22
	i32 2019465201, ; 108: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 67
	i32 2048185678, ; 109: Plugin.Media.dll => 0x7a14d54e => 12
	i32 2055257422, ; 110: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 63
	i32 2079903147, ; 111: System.Runtime.dll => 0x7bf8cdab => 30
	i32 2090596640, ; 112: System.Numerics.Vectors => 0x7c9bf920 => 28
	i32 2097448633, ; 113: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 59
	i32 2103459038, ; 114: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 21
	i32 2126786730, ; 115: Xamarin.Forms.Platform.Android => 0x7ec430aa => 96
	i32 2129483829, ; 116: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 101
	i32 2201107256, ; 117: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 111
	i32 2201231467, ; 118: System.Net.Http => 0x8334206b => 26
	i32 2217644978, ; 119: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 87
	i32 2244775296, ; 120: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 70
	i32 2256548716, ; 121: Xamarin.AndroidX.MultiDex => 0x8680336c => 72
	i32 2261435625, ; 122: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 61
	i32 2279755925, ; 123: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 79
	i32 2315684594, ; 124: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 34
	i32 2403452196, ; 125: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 55
	i32 2409053734, ; 126: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 76
	i32 2445024337, ; 127: Xamarin.Forms.GoogleMaps.Android.dll => 0x91bc1c51 => 94
	i32 2465273461, ; 128: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 18
	i32 2465532216, ; 129: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 45
	i32 2471841756, ; 130: netstandard.dll => 0x93554fdc => 113
	i32 2475788418, ; 131: Java.Interop.dll => 0x93918882 => 4
	i32 2501346920, ; 132: System.Data.DataSetExtensions => 0x95178668 => 116
	i32 2505896520, ; 133: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 66
	i32 2569075245, ; 134: BasesDeDatosLocales.Android => 0x9920fa2d => 0
	i32 2581819634, ; 135: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 88
	i32 2605712449, ; 136: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 111
	i32 2620871830, ; 137: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 50
	i32 2624644809, ; 138: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 54
	i32 2633051222, ; 139: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 64
	i32 2701096212, ; 140: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 85
	i32 2732626843, ; 141: Xamarin.AndroidX.Activity => 0xa2e0939b => 33
	i32 2737747696, ; 142: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 36
	i32 2766581644, ; 143: Xamarin.Forms.Core => 0xa4e6af8c => 93
	i32 2770495804, ; 144: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 105
	i32 2778768386, ; 145: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 90
	i32 2779977773, ; 146: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 80
	i32 2795602088, ; 147: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 15
	i32 2810250172, ; 148: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 47
	i32 2819470561, ; 149: System.Xml.dll => 0xa80db4e1 => 31
	i32 2821294376, ; 150: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 80
	i32 2847418871, ; 151: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 101
	i32 2853208004, ; 152: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 90
	i32 2855708567, ; 153: Xamarin.AndroidX.Transition => 0xaa36a797 => 86
	i32 2903344695, ; 154: System.ComponentModel.Composition => 0xad0d8637 => 120
	i32 2905242038, ; 155: mscorlib.dll => 0xad2a79b6 => 9
	i32 2912489636, ; 156: SkiaSharp.Views.Android => 0xad9910a4 => 15
	i32 2916838712, ; 157: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 91
	i32 2919462931, ; 158: System.Numerics.Vectors.dll => 0xae037813 => 28
	i32 2921128767, ; 159: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 35
	i32 2974793899, ; 160: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 16
	i32 2978675010, ; 161: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 53
	i32 2996846495, ; 162: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 65
	i32 3016983068, ; 163: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 83
	i32 3017076677, ; 164: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 103
	i32 3024354802, ; 165: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 60
	i32 3036068679, ; 166: Microcharts.Droid.dll => 0xb4f6bb47 => 6
	i32 3044182254, ; 167: FormsViewGroup => 0xb57288ee => 3
	i32 3057625584, ; 168: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 73
	i32 3058099980, ; 169: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 104
	i32 3085392760, ; 170: OxyPlot => 0xb7e75b78 => 11
	i32 3111772706, ; 171: System.Runtime.Serialization => 0xb979e222 => 1
	i32 3161802588, ; 172: BasesDeDatosLocales => 0xbc75475c => 2
	i32 3204380047, ; 173: System.Data.dll => 0xbefef58f => 114
	i32 3211777861, ; 174: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 52
	i32 3230466174, ; 175: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 102
	i32 3247949154, ; 176: Mono.Security => 0xc197c562 => 122
	i32 3258312781, ; 177: Xamarin.AndroidX.CardView => 0xc235e84d => 42
	i32 3267021929, ; 178: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 40
	i32 3286872994, ; 179: SQLite-net.dll => 0xc3e9b3a2 => 17
	i32 3317135071, ; 180: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 51
	i32 3317144872, ; 181: System.Data => 0xc5b79d28 => 114
	i32 3340387945, ; 182: SkiaSharp => 0xc71a4669 => 14
	i32 3340431453, ; 183: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 39
	i32 3345895724, ; 184: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 78
	i32 3346324047, ; 185: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 74
	i32 3353484488, ; 186: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 59
	i32 3360279109, ; 187: SQLitePCLRaw.core => 0xc849ca45 => 19
	i32 3362522851, ; 188: Xamarin.AndroidX.Core => 0xc86c06e3 => 49
	i32 3366347497, ; 189: Java.Interop => 0xc8a662e9 => 4
	i32 3374999561, ; 190: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 79
	i32 3395150330, ; 191: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 29
	i32 3404865022, ; 192: System.ServiceModel.Internals => 0xcaf21dfe => 112
	i32 3429136800, ; 193: System.Xml => 0xcc6479a0 => 31
	i32 3430777524, ; 194: netstandard => 0xcc7d82b4 => 113
	i32 3441283291, ; 195: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 54
	i32 3455791806, ; 196: Microcharts => 0xcdfb32be => 5
	i32 3459516321, ; 197: Xamarin.Forms.GoogleMaps => 0xce3407a1 => 95
	i32 3476120550, ; 198: Mono.Android => 0xcf3163e6 => 8
	i32 3486566296, ; 199: System.Transactions => 0xcfd0c798 => 115
	i32 3493954962, ; 200: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 44
	i32 3501239056, ; 201: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 40
	i32 3509114376, ; 202: System.Xml.Linq => 0xd128d608 => 32
	i32 3536029504, ; 203: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 96
	i32 3567349600, ; 204: System.ComponentModel.Composition.dll => 0xd4a16f60 => 120
	i32 3618140916, ; 205: Xamarin.AndroidX.Preference => 0xd7a872f4 => 76
	i32 3627220390, ; 206: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 77
	i32 3632359727, ; 207: Xamarin.Forms.Platform => 0xd881692f => 97
	i32 3633644679, ; 208: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 35
	i32 3641597786, ; 209: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 63
	i32 3668042751, ; 210: Microcharts.dll => 0xdaa1e3ff => 5
	i32 3672681054, ; 211: Mono.Android.dll => 0xdae8aa5e => 8
	i32 3676310014, ; 212: System.Web.Services.dll => 0xdb2009fe => 121
	i32 3682565725, ; 213: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 41
	i32 3684561358, ; 214: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 44
	i32 3689375977, ; 215: System.Drawing.Common => 0xdbe768e9 => 117
	i32 3706696989, ; 216: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 48
	i32 3718780102, ; 217: Xamarin.AndroidX.Annotation => 0xdda814c6 => 34
	i32 3724971120, ; 218: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 73
	i32 3754567612, ; 219: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 21
	i32 3758932259, ; 220: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 61
	i32 3786282454, ; 221: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 43
	i32 3822602673, ; 222: Xamarin.AndroidX.Media => 0xe3d849b1 => 71
	i32 3825730879, ; 223: BasesDeDatosLocales.Android.dll => 0xe408053f => 0
	i32 3829621856, ; 224: System.Numerics.dll => 0xe4436460 => 27
	i32 3876362041, ; 225: SQLite-net => 0xe70c9739 => 17
	i32 3885922214, ; 226: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 86
	i32 3888767677, ; 227: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 78
	i32 3896760992, ; 228: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 49
	i32 3903721208, ; 229: Microcharts.Forms => 0xe8ae0ef8 => 7
	i32 3920810846, ; 230: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 119
	i32 3921031405, ; 231: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 89
	i32 3931092270, ; 232: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 75
	i32 3945713374, ; 233: System.Data.DataSetExtensions.dll => 0xeb2ecede => 116
	i32 3955647286, ; 234: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 37
	i32 3959773229, ; 235: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 65
	i32 3970018735, ; 236: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 104
	i32 4025784931, ; 237: System.Memory => 0xeff49a63 => 25
	i32 4101593132, ; 238: Xamarin.AndroidX.Emoji2 => 0xf479582c => 55
	i32 4105002889, ; 239: Mono.Security.dll => 0xf4ad5f89 => 122
	i32 4151237749, ; 240: System.Core => 0xf76edc75 => 23
	i32 4182413190, ; 241: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 68
	i32 4256097574, ; 242: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 48
	i32 4260525087, ; 243: System.Buffers => 0xfdf2741f => 22
	i32 4278134329, ; 244: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 103
	i32 4292120959 ; 245: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 68
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [246 x i32] [
	i32 11, i32 66, i32 100, i32 10, i32 13, i32 93, i32 82, i32 82, ; 0..7
	i32 108, i32 43, i32 84, i32 41, i32 60, i32 121, i32 46, i32 64, ; 8..15
	i32 58, i32 33, i32 27, i32 62, i32 20, i32 25, i32 45, i32 92, ; 16..23
	i32 57, i32 9, i32 24, i32 58, i32 70, i32 14, i32 115, i32 108, ; 24..31
	i32 119, i32 51, i32 56, i32 89, i32 38, i32 32, i32 110, i32 2, ; 32..39
	i32 105, i32 109, i32 18, i32 118, i32 117, i32 77, i32 6, i32 100, ; 40..47
	i32 10, i32 109, i32 62, i32 3, i32 81, i32 37, i32 97, i32 67, ; 48..55
	i32 107, i32 24, i32 12, i32 13, i32 87, i32 74, i32 38, i32 83, ; 56..63
	i32 88, i32 110, i32 19, i32 53, i32 95, i32 112, i32 94, i32 81, ; 64..71
	i32 71, i32 47, i32 29, i32 98, i32 118, i32 36, i32 52, i32 7, ; 72..79
	i32 1, i32 69, i32 91, i32 56, i32 50, i32 26, i32 30, i32 85, ; 80..87
	i32 99, i32 46, i32 106, i32 20, i32 16, i32 42, i32 84, i32 23, ; 88..95
	i32 57, i32 69, i32 107, i32 99, i32 75, i32 92, i32 98, i32 39, ; 96..103
	i32 102, i32 72, i32 106, i32 22, i32 67, i32 12, i32 63, i32 30, ; 104..111
	i32 28, i32 59, i32 21, i32 96, i32 101, i32 111, i32 26, i32 87, ; 112..119
	i32 70, i32 72, i32 61, i32 79, i32 34, i32 55, i32 76, i32 94, ; 120..127
	i32 18, i32 45, i32 113, i32 4, i32 116, i32 66, i32 0, i32 88, ; 128..135
	i32 111, i32 50, i32 54, i32 64, i32 85, i32 33, i32 36, i32 93, ; 136..143
	i32 105, i32 90, i32 80, i32 15, i32 47, i32 31, i32 80, i32 101, ; 144..151
	i32 90, i32 86, i32 120, i32 9, i32 15, i32 91, i32 28, i32 35, ; 152..159
	i32 16, i32 53, i32 65, i32 83, i32 103, i32 60, i32 6, i32 3, ; 160..167
	i32 73, i32 104, i32 11, i32 1, i32 2, i32 114, i32 52, i32 102, ; 168..175
	i32 122, i32 42, i32 40, i32 17, i32 51, i32 114, i32 14, i32 39, ; 176..183
	i32 78, i32 74, i32 59, i32 19, i32 49, i32 4, i32 79, i32 29, ; 184..191
	i32 112, i32 31, i32 113, i32 54, i32 5, i32 95, i32 8, i32 115, ; 192..199
	i32 44, i32 40, i32 32, i32 96, i32 120, i32 76, i32 77, i32 97, ; 200..207
	i32 35, i32 63, i32 5, i32 8, i32 121, i32 41, i32 44, i32 117, ; 208..215
	i32 48, i32 34, i32 73, i32 21, i32 61, i32 43, i32 71, i32 0, ; 216..223
	i32 27, i32 17, i32 86, i32 78, i32 49, i32 7, i32 119, i32 89, ; 224..231
	i32 75, i32 116, i32 37, i32 65, i32 104, i32 25, i32 55, i32 122, ; 232..239
	i32 23, i32 68, i32 48, i32 22, i32 103, i32 68 ; 240..245
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a8a26c7b003e2524cc98acb2c2ffc2ddea0f6692"}
!llvm.linker.options = !{}
