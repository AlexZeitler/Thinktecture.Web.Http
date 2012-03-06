using System.Web.Http;
using Raven.Client;

namespace Thinktecture.Web.Http.Controllers {
	/// <summary>
	/// A Web Api Base Controller providing a RavenDB Document Session
	/// </summary>
	public class RavenController : ApiController {
		public new IDocumentSession Session { get; set; }
	}
}