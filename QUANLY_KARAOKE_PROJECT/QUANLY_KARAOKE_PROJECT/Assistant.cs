using System;
using System.Speech.Synthesis;
using System.Linq;

namespace QUANLY_KARAOKE_PROJECT
{
    public class Assistant
    {
        private SpeechSynthesizer _synth;

        public Assistant()
        {
            _synth = new SpeechSynthesizer();
            SetVietnameseVoice(); // Cấu hình giọng nói tiếng Việt
        }

        // Hàm để chọn giọng nói tiếng Việt (nếu có)
        private void SetVietnameseVoice()
        {
            try
            {
                // Tìm giọng nói "Microsoft An" trên hệ thống
                var vietnameseVoice = _synth.GetInstalledVoices()
                                            .FirstOrDefault(v => v.VoiceInfo.Name.Contains("Microsoft An"));

                if (vietnameseVoice != null)
                {
                    _synth.SelectVoice(vietnameseVoice.VoiceInfo.Name);
                    Console.WriteLine($"Đã chọn giọng nói: {vietnameseVoice.VoiceInfo.Name}");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy giọng nói Microsoft An trên hệ thống.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi chọn giọng nói: {ex.Message}");
            }
        }


        // Hàm để phát âm thanh thông báo
        public void Speak(string text)
        {
            try
            {
                _synth.SpeakAsync(text); // Phát âm thanh không đồng bộ
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi phát giọng nói: {ex.Message}");
            }
        }

        // Tùy chỉnh tốc độ và âm lượng
        public void ConfigureVoice(int rate = 1, int volume = 100)
        {
            _synth.Rate = rate;    // Tốc độ giọng nói (-10 đến 10)
            _synth.Volume = volume; // Âm lượng (0-100)
        }

        public void Dispose()
        {
            _synth.Dispose();
        }
    }
}
