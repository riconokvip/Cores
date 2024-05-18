namespace Cores.Configs
{
    public static partial class CoreExtensions
    {
        /// <summary>
        /// Thời gian hiện tại
        /// </summary>
        public static DateTime TIME_NOW = DateTime.UtcNow;

        /// <summary>
        /// Ngày hiện tại
        /// </summary>
        public static DateTime DATE_NOW = DateTime.UtcNow.Date;

        /// <summary>
        /// Giới hạn kích thước tệp tải lên
        /// </summary>
        public const int IMAGE_LIMIT = 2 * 1024 * 1024;
    }
}
