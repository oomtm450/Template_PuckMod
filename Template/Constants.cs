namespace oomtm450PuckMod_Template {
    public static class Constants {
        /// <summary>
        /// Const string, name of the mod on the workshop.
        /// </summary>
        internal const string WORKSHOP_MOD_NAME = "Template";

        /// <summary>
        /// Const string, name of the mod.
        /// </summary>
        internal const string MOD_NAME = "oomtm450_template";

        /// <summary>
        /// Const string, used for the communication from the server.
        /// </summary>
        internal const string FROM_SERVER_TO_CLIENT = MOD_NAME + "_server";

        /// <summary>
        /// Const string, used for the communication from the client.
        /// </summary>
        internal const string FROM_CLIENT_TO_SERVER = MOD_NAME + "_client";

        /// <summary>
        /// Const string, tag to ask the server for the startup data.
        /// </summary>
        internal const string ASK_SERVER_FOR_STARTUP_DATA = Constants.MOD_NAME + "ASKDATA";
    }
}
