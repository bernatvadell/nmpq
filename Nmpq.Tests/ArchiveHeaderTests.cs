using NUnit.Framework;

namespace Nmpq.Tests {
	[TestFixture]
	public class ArchiveHeaderTests {
		[Test]
		public void Magic_is_read_as_expected() {
			using(var archive = TestArchiveFactory.OpenTestArchive1()) {
				var magic = archive.ArchiveHeader.Magic;

				Assert.That(magic, Is.EqualTo(0x1a51504d));
			}
		}

		[Test]
		public void Header_size_is_read_as_expected() {
			using(var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.HeaderSize, Is.EqualTo(0x2c));
			}
		}

		[Test]
		public void Archive_size_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.ArchiveSize, Is.EqualTo(83244));
			}
		}

		[Test]
		public void Format_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.FormatVersion, Is.EqualTo(1));
			}
		}

		[Test]
		public void Sector_size_shift_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.SectorSizeShift, Is.EqualTo(3));
			}
		}

		[Test]
		public void Hash_table_offset_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.HashTableOffset, Is.EqualTo(0x0001438c));
			}
		}

		[Test]
		public void Block_table_offset_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.BlockTableOffset, Is.EqualTo(0x0001448c));
			}
		}

		[Test]
		public void Hash_table_entry_count_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.HashTableEntryCount, Is.EqualTo(16));
			}
		}

		[Test]
		public void Block_table_entry_count_is_read_as_expected() {
			using (var archive = TestArchiveFactory.OpenTestArchive1()) {
				Assert.That(archive.ArchiveHeader.BlockTableEntryCount, Is.EqualTo(10));
			}
		}
	}
}