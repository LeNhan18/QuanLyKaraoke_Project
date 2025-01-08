using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Assistant
{
    public class Program
    {
        static void Main(string[] args)
        {
            var assistant = new Assistant();
            assistant.ConfigureVoice(rate: 0, volume: 0);
            Console.WriteLine("Hệ thống sẽ thử phát giọng nói.");
            assistant.Speak("Xin chào, đây là thử nghiệm phát giọng nói tiếng Việt từ ứng dụng karaoke.");
            Console.WriteLine("Đã phát giọng nói xong. Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
            assistant.Dispose();
        }
    }
    public class Assistant
    {
        private SpeechSynthesizer _synth;
        public Assistant()
        {
            _synth = new SpeechSynthesizer();
            SetVietnameseVoice();
            ListAvailableVoices();
        }
        private void SetVietnameseVoice()
        {
            try
            {
                var vietnameseVoice = _synth.GetInstalledVoices()
                                            .FirstOrDefault(v => v.VoiceInfo.Name.Contains("An"));
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
        public void Speak(string text)
        {
            try
            {
                _synth.SpeakAsync(text); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi phát giọng nói: {ex.Message}");
            }
        }

        // Tùy chỉnh tốc độ và âm lượng
        public void ConfigureVoice(int rate = 1, int volume = 0)
        {
            _synth.Rate = rate;    // Tốc độ giọng nói (-10 đến 10)
            _synth.Volume = volume; // Âm lượng (0-100)
        }


        public void Dispose()
        {
            _synth.Dispose();
        }
        public void ListAvailableVoices()
        {
            Console.WriteLine("Danh sách giọng nói khả dụng:");
            foreach (var voice in _synth.GetInstalledVoices())
            {
                var info = voice.VoiceInfo;
                Console.WriteLine($"Name: {info.Name}, Culture: {info.Culture}, Gender: {info.Gender}");
            }
        }

    }
} 

