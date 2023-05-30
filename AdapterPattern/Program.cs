using AdapterPattern;

var legacyLibrary = new LegacyLibrary();

ITarget adapter = new Adapter(legacyLibrary);

// Create the client and pass the adapter instance
Client client = new Client(adapter);

// Client makes a request through the adapter
client.MakeRequest();
