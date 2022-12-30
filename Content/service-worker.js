const cacheName = 'MyFancyCacheName_v3';

// Assets to precache
const precachedAssets = [
    '/Content/Site.css',
    '/Home/About'
];

self.addEventListener('install', (event) => {
    // Precache assets on install
    event.waitUntil(caches.open(cacheName).then((cache) => {
        return cache.addAll(precachedAssets);
    }));
});




// activation
self.addEventListener('activate', e => {
    console.log('Service Worker: Installed');
}); 

