using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using ParseContabil.Domain.Dtos;
using ParseContabil.Domain.Entities;
using ParseContabil.Domain.Interfaces.Repositories;
using ParseContabil.Domain.Interfaces.Services;
using ParseContabil.Domain.Services;
using System.Text;

namespace ParseContabil.DomainUnitTest.Services
{
    public class ParserServiceTest
    {
        private readonly Mock<IRecordTypeRepository> _recordRepository;
        private readonly Mock<IProcessTaskLogRepository> _processTaskLogRepository;
        private readonly Mock<IFilesHandlerWrapper> _filesHandlerWrapper;
        private readonly ParserService _parserService;

        public ParserServiceTest()
        {
            _recordRepository = new Mock<IRecordTypeRepository>();
            _processTaskLogRepository = new Mock<IProcessTaskLogRepository>();
            _filesHandlerWrapper = new Mock<IFilesHandlerWrapper>();
            var configurationOptions = Options.Create(new Configuration {PathOutput = string.Empty});
            var logger = new Mock<ILogger<ParserService>>();
            
            _parserService = new ParserService(_recordRepository.Object,_processTaskLogRepository.Object, configurationOptions, logger.Object, _filesHandlerWrapper.Object);
        }

        [Fact]
        public async Task When_ProcessInputFileAsync_Success()
        {
            var processTask = new ProcessTaskLog { Status = (short)TaskStatus.Running, Start = DateTime.Now };
            _processTaskLogRepository.Setup(p => p.StartAsync()).ReturnsAsync(processTask);
            _processTaskLogRepository.Setup(p => p.StopAsync(processTask)).Returns(Task.CompletedTask);
            _recordRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(Fixtures.Fixtures.GetRecordType);
            _filesHandlerWrapper.Setup(f => f.GenerateFilesOutputAsync(It.IsAny<Dictionary<string, StringBuilder>>(), It.IsAny<string>()));

            await _parserService.ProcessInputFileAsync(Fixtures.Fixtures.GetFile());

            _filesHandlerWrapper.Verify(f => f.GenerateFilesOutputAsync(It.IsAny<Dictionary<string, StringBuilder>>(), It.IsAny<string>()), Times.Once);
        }
        
        [Fact]
        public async Task When_ProcessInputFileAsync_Fail()
        {
            var processTask = new ProcessTaskLog { Status = (short)TaskStatus.Running, Start = DateTime.Now };
            _processTaskLogRepository.Setup(p => p.StartAsync()).ReturnsAsync(processTask);
            _processTaskLogRepository.Setup(p => p.StopAsync(processTask)).Returns(Task.CompletedTask);
            _recordRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<RecordType>());
            _filesHandlerWrapper.Setup(f => f.GenerateFilesOutputAsync(It.IsAny<Dictionary<string, StringBuilder>>(), It.IsAny<string>()));

            await _parserService.ProcessInputFileAsync(Fixtures.Fixtures.GetFile());

            _filesHandlerWrapper.Verify(f => f.GenerateFilesOutputAsync(It.IsAny<Dictionary<string, StringBuilder>>(), It.IsAny<string>()), Times.Never);
        }
    }
}
